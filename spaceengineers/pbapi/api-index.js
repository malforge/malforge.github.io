// Expand tree to show active link and scroll into view
document.addEventListener('DOMContentLoaded', function() {
    // Sidebar toggle functionality
    const sidebarToggle = document.getElementById('sidebar-toggle');
    const body = document.body;
    
    // Check if we should start with sidebar collapsed on mobile/tablet
    if (window.innerWidth <= 1024) {
        body.classList.add('sidebar-collapsed');
    }
    
    sidebarToggle.addEventListener('click', function(e) {
        e.stopPropagation();
        body.classList.toggle('sidebar-collapsed');
        sidebarToggle.classList.toggle('active');
    });
    
    // Close sidebar when clicking on content on mobile/tablet
    document.addEventListener('click', function(e) {
        if (window.innerWidth <= 1024 && 
            !e.target.closest('.sidebar') && 
            !e.target.closest('.sidebar-toggle') &&
            !body.classList.contains('sidebar-collapsed')) {
            body.classList.add('sidebar-collapsed');
            sidebarToggle.classList.remove('active');
        }
    });
    
    // Close sidebar when clicking a link on mobile/tablet
    const sidebarLinks = document.querySelectorAll('.sidebar-nav a');
    sidebarLinks.forEach(link => {
        link.addEventListener('click', function() {
            if (window.innerWidth <= 1024) {
                body.classList.add('sidebar-collapsed');
                sidebarToggle.classList.remove('active');
            }
        });
    });
    
    // Handle window resize
    window.addEventListener('resize', function() {
        if (window.innerWidth > 1024) {
            body.classList.remove('sidebar-collapsed');
            sidebarToggle.classList.remove('active');
        }
    });

    // Sidebar resize functionality
    const resizeHandle = document.querySelector('.sidebar-resize-handle');
    const sidebar = document.querySelector('.sidebar');
    let isResizing = false;
    let startX = 0;
    let startWidth = 0;

    // Load saved width from localStorage
    const savedWidth = localStorage.getItem('sidebarWidth');
    if (savedWidth && window.innerWidth > 1024) {
        document.documentElement.style.setProperty('--sidebar-width', savedWidth + 'px');
    }

    resizeHandle.addEventListener('mousedown', function(e) {
        // Only enable resize on desktop
        if (window.innerWidth <= 1024) return;

        isResizing = true;
        startX = e.clientX;
        startWidth = sidebar.offsetWidth;
        resizeHandle.classList.add('resizing');
        document.body.style.cursor = 'col-resize';
        document.body.style.userSelect = 'none';
        e.preventDefault();
    });

    document.addEventListener('mousemove', function(e) {
        if (!isResizing) return;

        const delta = e.clientX - startX;
        const newWidth = startWidth + delta;

        // Get constraints from CSS variables
        const minWidth = parseInt(getComputedStyle(document.documentElement).getPropertyValue('--sidebar-min-width'));
        const maxWidth = parseInt(getComputedStyle(document.documentElement).getPropertyValue('--sidebar-max-width'));

        // Constrain width
        const constrainedWidth = Math.max(minWidth, Math.min(maxWidth, newWidth));

        document.documentElement.style.setProperty('--sidebar-width', constrainedWidth + 'px');
    });

    document.addEventListener('mouseup', function() {
        if (!isResizing) return;

        isResizing = false;
        resizeHandle.classList.remove('resizing');
        document.body.style.cursor = '';
        document.body.style.userSelect = '';

        // Save width to localStorage
        const currentWidth = sidebar.offsetWidth;
        localStorage.setItem('sidebarWidth', currentWidth);
    });

    // Double-click to reset to default width
    resizeHandle.addEventListener('dblclick', function() {
        if (window.innerWidth <= 1024) return;

        document.documentElement.style.setProperty('--sidebar-width', '320px');
        localStorage.setItem('sidebarWidth', 320);
    });

    const activeLink = document.querySelector('.sidebar-nav a.active');
    if (activeLink) {
        // Expand all parent <details> elements
        let parent = activeLink.parentElement;
        while (parent) {
            if (parent.tagName === 'DETAILS') {
                parent.open = true;
            }
            parent = parent.parentElement;
        }
        // Scroll into view
        activeLink.scrollIntoView({ behavior: 'auto', block: 'center' });
    }
    
    // Search functionality
    const searchInput = document.getElementById('search-input');
    const clearButton = document.getElementById('clear-search');
    let searchIndex = [];
    
    // Load search index from JSON
    fetch('search-index.json')
        .then(response => response.json())
        .then(data => {
            searchIndex = data;
            console.log(`Loaded search index with ${searchIndex.length} items`);
        })
        .catch(error => {
            console.error('Failed to load search index:', error);
        });
    
    const resultsDiv = document.getElementById('search-results');
    const MAX_RESULTS = 100;
    let selectedIndex = -1;
    let currentPage = 0;
    let currentMatches = [];
    
    // Search and show results in dropdown
    function performSearch(query) {
        query = query.toLowerCase().trim();
        selectedIndex = -1;
        currentPage = 0;
        
        if (!query) {
            clearButton.style.display = 'none';
            resultsDiv.style.display = 'none';
            resultsDiv.innerHTML = '';
            return;
        }
        
        // Check if index is loaded
        if (searchIndex.length === 0) {
            resultsDiv.innerHTML = '<div class="search-results-container"><div class="search-no-results">Loading search index...</div></div>';
            resultsDiv.style.display = 'grid';
            return;
        }
        
        clearButton.style.display = 'block';
        
        // Check for search prefix filters
        let filterType = null;
        let searchQuery = query;
        
        if (query.startsWith('t:')) {
            filterType = 'type';
            searchQuery = query.substring(2).trim();
        } else if (query.startsWith('m:')) {
            filterType = 'member';
            searchQuery = query.substring(2).trim();
        }
        
        if (!searchQuery) {
            resultsDiv.innerHTML = '<div class="search-results-container"><div class="search-no-results">Enter search term after prefix</div></div><div class="search-feedback"><p><small>If search isn\'t meeting your needs, please provide feedback!</small></p></div>';
            resultsDiv.style.display = 'grid';
            return;
        }
        
        // Find and rank matches from JSON index
        currentMatches = searchIndex.filter(item => {
            // Check if search term matches
            const nameMatch = item.name.toLowerCase().includes(searchQuery);
            const fullNameMatch = item.fullName.toLowerCase().includes(searchQuery);
            
            if (!nameMatch && !fullNameMatch) return false;
            
            // Apply type filter if specified
            if (filterType === 'type') {
                return item.type === 'type' || item.type === 'namespace';
            } else if (filterType === 'member') {
                return item.type === 'member';
            }
            
            return true;
        });
        
        // Rank matches: exact > starts with > contains, types > members
        currentMatches.sort((a, b) => {
            const aName = a.name.toLowerCase();
            const bName = b.name.toLowerCase();
            const aFull = a.fullName.toLowerCase();
            const bFull = b.fullName.toLowerCase();
            
            const aExact = (aName === searchQuery || aFull === searchQuery) ? 4 : 0;
            const bExact = (bName === searchQuery || bFull === searchQuery) ? 4 : 0;
            const aStarts = (aName.startsWith(searchQuery) || aFull.startsWith(searchQuery)) ? 3 : 0;
            const bStarts = (bName.startsWith(searchQuery) || bFull.startsWith(searchQuery)) ? 3 : 0;
            const aWordStart = (aFull.includes(' ' + searchQuery) || aFull.includes('.' + searchQuery)) ? 2 : 0;
            const bWordStart = (bFull.includes(' ' + searchQuery) || bFull.includes('.' + searchQuery)) ? 2 : 0;
            const aIsType = (a.type === 'type' || a.type === 'namespace') ? 1 : 0;
            const bIsType = (b.type === 'type' || b.type === 'namespace') ? 1 : 0;
            
            const aScore = aExact + aStarts + aWordStart + aIsType;
            const bScore = bExact + bStarts + bWordStart + bIsType;
            
            if (aScore !== bScore) return bScore - aScore;
            return aName.length - bName.length;
        });
        
        displayResults();
    }
    
    function displayResults() {
        if (currentMatches.length === 0) {
            resultsDiv.innerHTML = '<div class="search-results-container"><div class="search-no-results">No results found</div></div><div class="search-feedback"><p><small>If search isn\'t meeting your needs, please provide feedback!</small></p></div>';
            resultsDiv.style.display = 'grid';
            return;
        }
        
        const totalPages = Math.ceil(currentMatches.length / MAX_RESULTS);
        const startIdx = currentPage * MAX_RESULTS;
        const endIdx = Math.min(startIdx + MAX_RESULTS, currentMatches.length);
        const pageMatches = currentMatches.slice(startIdx, endIdx);
        let html = '';
        
        // Show count and pagination
        if (currentMatches.length > MAX_RESULTS) {
            html += `<div class="search-count">
                <span>Showing ${startIdx + 1}-${endIdx} of ${currentMatches.length} results</span>
                <div class="search-pagination">
                    <button class="page-prev" ${currentPage === 0 ? 'disabled' : ''}>‹ Previous</button>
                    <span>Page ${currentPage + 1} of ${totalPages}</span>
                    <button class="page-next" ${currentPage >= totalPages - 1 ? 'disabled' : ''}>Next ›</button>
                </div>
            </div>`;
        } else {
            html += `<div class="search-count">${currentMatches.length} result${currentMatches.length > 1 ? 's' : ''}</div>`;
        }
        
        // Results container
        html += '<div class="search-results-container">';
        
        // Build result items
        pageMatches.forEach((item, index) => {
            const displayName = item.name;
            const fullName = item.fullName;
            const itemPath = item.path;
            
            // Determine prefix based on type
            let prefix = '';
            if (item.type === 'namespace') {
                prefix = 'Namespace';
            } else if (item.type === 'type') {
                prefix = 'Type';
            } else if (item.type === 'member') {
                prefix = 'Member';
            }
            
            // Context (namespace/parent)
            let context = '';
            const dotIndex = fullName.lastIndexOf('.');
            const atIndex = fullName.lastIndexOf('@');
            const plusIndex = fullName.lastIndexOf('+');
            
            if (atIndex > 0) {
                // Member - show parent type
                context = fullName.substring(0, atIndex).replace('+', '.');
            } else if (plusIndex > 0) {
                // Nested type - show parent
                context = fullName.substring(0, plusIndex);
            } else if (dotIndex > 0) {
                // Type - show namespace
                context = fullName.substring(0, dotIndex);
            }
            
            html += `
                <a href="${itemPath}" class="search-result-item" data-index="${index}">
                    <div class="search-result-prefix">${prefix}</div>
                    <div class="search-result-title">${displayName}</div>
                    ${context ? `<div class="search-result-context">${context}</div>` : ''}
                </a>
            `;
        });
        
        html += '</div>'; // close search-results-container
        
        // Add feedback section (placeholder - will be replaced by template content)
        html += `<div class="search-feedback"><p><small>If search isn\'t meeting your needs, please provide feedback!</small></p></div>`;
        
        resultsDiv.innerHTML = html;
        resultsDiv.style.display = 'grid';
    }
    
    // Keyboard navigation for results
    searchInput.addEventListener('keydown', function(e) {
        if (!resultsDiv.style.display || resultsDiv.style.display === 'none') return;
        
        const items = resultsDiv.querySelectorAll('.search-result-item');
        if (items.length === 0) return;
        
        if (e.key === 'ArrowDown') {
            e.preventDefault();
            selectedIndex = Math.min(selectedIndex + 1, items.length - 1);
            updateSelection(items);
        } else if (e.key === 'ArrowUp') {
            e.preventDefault();
            selectedIndex = Math.max(selectedIndex - 1, 0);
            updateSelection(items);
        } else if (e.key === 'Enter' && selectedIndex >= 0) {
            e.preventDefault();
            items[selectedIndex].click();
        } else if (e.key === 'Escape') {
            searchInput.value = '';
            performSearch('');
        }
    });
    
    function updateSelection(items) {
        items.forEach((item, index) => {
            if (index === selectedIndex) {
                item.classList.add('selected');
                item.scrollIntoView({ block: 'nearest', behavior: 'smooth' });
            } else {
                item.classList.remove('selected');
            }
        });
    }
    
    // Event delegation for pagination buttons
    resultsDiv.addEventListener('click', function(e) {
        if (e.target.classList.contains('page-next')) {
            e.stopPropagation();
            const totalPages = Math.ceil(currentMatches.length / MAX_RESULTS);
            if (currentPage < totalPages - 1) {
                currentPage++;
                selectedIndex = -1;
                displayResults();
            }
        } else if (e.target.classList.contains('page-prev')) {
            e.stopPropagation();
            if (currentPage > 0) {
                currentPage--;
                selectedIndex = -1;
                displayResults();
            }
        }
    });
    
    // Event listeners
    searchInput.addEventListener('input', function(e) {
        performSearch(e.target.value);
    });
    
    clearButton.addEventListener('click', function() {
        searchInput.value = '';
        performSearch('');
        searchInput.focus();
    });
    
    // Close dropdown when clicking outside
    document.addEventListener('click', function(e) {
        if (!e.target.closest('.sidebar-header') && !e.target.closest('#search-results')) {
            resultsDiv.style.display = 'none';
        }
    });
    
    // Keyboard shortcut: Ctrl+K or Cmd+K to focus search
    document.addEventListener('keydown', function(e) {
        if ((e.ctrlKey || e.metaKey) && e.key === 'k') {
            e.preventDefault();
            searchInput.focus();
            searchInput.select();
        }
    });
    
    // Sidebar scroll-to-top button
    const sidebarNav = document.querySelector('.sidebar-nav');
    const scrollTopBtn = document.getElementById('sidebar-scroll-top');

    if (sidebarNav && scrollTopBtn) {
        sidebarNav.addEventListener('scroll', function() {
            if (sidebarNav.scrollTop > 200) {
                scrollTopBtn.style.display = 'block';
            } else {
                scrollTopBtn.style.display = 'none';
            }
        });

        scrollTopBtn.addEventListener('click', function() {
            sidebarNav.scrollTo({ top: 0, behavior: 'smooth' });
        });
    }
});
