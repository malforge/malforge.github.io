**Assembly:** VRage.dll

```csharp
public abstract sealed class MyUtils
```

MyFileSystemUtils

## Fields

|Member|Description|
|---|---|
|[static C_CRLF](VRage.Utils.MyUtils@C_CRLF)||
|[static DefaultNumberSuffix](VRage.Utils.MyUtils@DefaultNumberSuffix)|Default number suffix, k = thousand, m = million, g/b = billion|
|[static EmptyStringBuilder](VRage.Utils.MyUtils@EmptyStringBuilder)||
|[static ZeroMatrix](VRage.Utils.MyUtils@ZeroMatrix)||

## Properties

|Member|Description|
|---|---|
|[static MainThread](VRage.Utils.MyUtils@MainThread)||

## Methods

|Member|Description|
|---|---|
|[static AlignCoord(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@AlignCoord)||
|[static AlignIntToRight(int, int, char)](VRage.Utils.MyUtils@AlignIntToRight)||
|[static AssertIsValid(Matrix)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(MatrixD)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(Vector3)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(Vector3D)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(Vector3?)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(Vector2)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(float)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(double)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValid(Quaternion)](VRage.Utils.MyUtils@AssertIsValid)||
|[static AssertIsValidOrZero(Matrix)](VRage.Utils.MyUtils@AssertIsValidOrZero)||
|[static AssertLengthValid(ref Vector3)](VRage.Utils.MyUtils@AssertLengthValid)||
|[static AssertLengthValid(ref Vector3D)](VRage.Utils.MyUtils@AssertLengthValid)||
|[static CheckFloatValues(object, string, ref double?, ref double?)](VRage.Utils.MyUtils@CheckFloatValues)||
|[static CheckMainThread(string)](VRage.Utils.MyUtils@CheckMainThread)||
|[static DeserializeValue(XmlReader, out Vector3)](VRage.Utils.MyUtils@DeserializeValue)||
|[static DeserializeValue(XmlReader, out Vector4)](VRage.Utils.MyUtils@DeserializeValue)||
|[static FormatByteSizePrefix(ref double)](VRage.Utils.MyUtils@FormatByteSizePrefix)||
|[static GenerateBoxColors()](VRage.Utils.MyUtils@GenerateBoxColors)||
|[static GenerateQuad(out MyQuadD, ref Vector3D, float, float, ref MatrixD)](VRage.Utils.MyUtils@GenerateQuad)|Generate oriented quad by matrix|
|[static GetAngleBetweenVectors(Vector3, Vector3)](VRage.Utils.MyUtils@GetAngleBetweenVectors)|Calculating the Angle between two Vectors (return in radians).|
|[static GetAngleBetweenVectorsAndNormalise(Vector3, Vector3)](VRage.Utils.MyUtils@GetAngleBetweenVectorsAndNormalise)||
|[static GetAngleBetweenVectorsForSphereCollision(Vector3, Vector3)](VRage.Utils.MyUtils@GetAngleBetweenVectorsForSphereCollision)||
|[static GetBillboardQuadAdvancedRotated(out MyQuadD, Vector3D, float, float, float, Vector3D)](VRage.Utils.MyUtils@GetBillboardQuadAdvancedRotated)||
|[static GetBillboardQuadAdvancedRotated(out MyQuadD, Vector3D, float, float, Vector3D)](VRage.Utils.MyUtils@GetBillboardQuadAdvancedRotated)||
|[static GetBillboardQuadOriented(out MyQuadD, ref Vector3D, float, float, ref Vector3, ref Vector3)](VRage.Utils.MyUtils@GetBillboardQuadOriented)|This billboard isn't facing the camera. It's always oriented in specified direction. May be used as thrusts, or inner light of reflector.|
|[static GetBoolFromString(string)](VRage.Utils.MyUtils@GetBoolFromString)||
|[static GetBoolFromString(string, bool)](VRage.Utils.MyUtils@GetBoolFromString)||
|[static GetBoundingSphereFromBoundingBox(ref BoundingBoxD)](VRage.Utils.MyUtils@GetBoundingSphereFromBoundingBox)||
|[static GetByteFromString(string)](VRage.Utils.MyUtils@GetByteFromString)||
|[static GetCartesianCoordinatesFromSpherical(float, float, float)](VRage.Utils.MyUtils@GetCartesianCoordinatesFromSpherical)||
|[static GetClampInt(int, int, int)](VRage.Utils.MyUtils@GetClampInt)||
|[static GetClosestPointOnLine(ref Vector3, ref Vector3, ref Vector3)](VRage.Utils.MyUtils@GetClosestPointOnLine)||
|[static GetClosestPointOnLine(ref Vector3D, ref Vector3D, ref Vector3D)](VRage.Utils.MyUtils@GetClosestPointOnLine)||
|[static GetClosestPointOnLine(ref Vector3, ref Vector3, ref Vector3, out float)](VRage.Utils.MyUtils@GetClosestPointOnLine)||
|[static GetClosestPointOnLine(ref Vector3D, ref Vector3D, ref Vector3D, out double)](VRage.Utils.MyUtils@GetClosestPointOnLine)||
|[static GetCoordAligned(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordAligned)|Aligns rectangle, works in screen/texture/pixel coordinates, not normalized coordinates.|
|[static GetCoordAlignedFromCenter(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordAlignedFromCenter)|Modifies input coordinate (in center) using alignment and size of the rectangle. Result is at position inside rectangle specified by alignment.|
|[static GetCoordAlignedFromRectangle(ref RectangleF, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordAlignedFromRectangle)|Returns coordinate within given rectangle specified by draw align. Rectangle position should be upper left corner. Conversion assumes that Y coordinates increase downwards.|
|[static GetCoordAlignedFromTopLeft(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordAlignedFromTopLeft)||
|[static GetCoordCenterFromAligned(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordCenterFromAligned)|Reverses effect of alignment to compute center coordinate.|
|[static GetCoordTopLeftFromAligned(Vector2, Vector2, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordTopLeftFromAligned)|Reverses effect of alignment to compute top-left corner coordinate.|
|[static GetCoordTopLeftFromAligned(Vector2I, Vector2I, MyGuiDrawAlignEnum)](VRage.Utils.MyUtils@GetCoordTopLeftFromAligned)|Reverses effect of alignment to compute top-left corner coordinate.|
|[static GetEdgeSphereCollision(ref Vector3, float, ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetEdgeSphereCollision)|Returns intersection point between sphere and its edges. But only if there is intersection between sphere and one of the edges. If sphere intersects somewhere inside the triangle, this method will not detect it.|
|[static GetFixedInvalidFileNameChars()](VRage.Utils.MyUtils@GetFixedInvalidFileNameChars)||
|[static GetFixedInvalidPathChars()](VRage.Utils.MyUtils@GetFixedInvalidPathChars)||
|[static GetFloatFromString(string)](VRage.Utils.MyUtils@GetFloatFromString)||
|[static GetFloatFromString(string, float)](VRage.Utils.MyUtils@GetFloatFromString)||
|[static GetHash(double, int)](VRage.Utils.MyUtils@GetHash)||
|[static GetHash(string, int)](VRage.Utils.MyUtils@GetHash)||
|[static GetHash(string, int, int, int)](VRage.Utils.MyUtils@GetHash)||
|[static GetHashUpperCase(string, int, int, int)](VRage.Utils.MyUtils@GetHashUpperCase)||
|[static GetInsidePolygonForSphereCollision(ref Vector3D, ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetInsidePolygonForSphereCollision)|Return true if point is inside the triangle.|
|[static GetInsidePolygonForSphereCollision(ref Vector3, ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetInsidePolygonForSphereCollision)|Return true if point is inside the triangle.|
|[static GetInt32FromString(string)](VRage.Utils.MyUtils@GetInt32FromString)||
|[static GetIntFromString(string)](VRage.Utils.MyUtils@GetIntFromString)||
|[static GetIntFromString(string, int)](VRage.Utils.MyUtils@GetIntFromString)||
|[static GetLargestDistanceToSphere(ref Vector3D, ref BoundingSphereD)](VRage.Utils.MyUtils@GetLargestDistanceToSphere)|Distance between "from" and opposite side of the "sphere". Always positive.|
|[static GetLineBoundingBoxIntersection(ref Line, ref BoundingBox)](VRage.Utils.MyUtils@GetLineBoundingBoxIntersection)|Calculates intersection between line and bounding box and if found, distance is returned. Otherwise null is returned.|
|[static GetLineTriangleIntersection(ref Line, ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetLineTriangleIntersection)|Checks whether a ray intersects a triangleVertexes. This uses the algorithm developed by Tomas Moller and Ben Trumbore, which was published in the Journal of Graphics Tools, pitch 2, "Fast, Minimum Storage Ray-Triangle Intersection". This method is implemented using the pass-by-reference versions of the XNA math functions. Using these overloads is generally not recommended, because they make the code less readable than the normal pass-by-value versions. This method can be called very frequently in a tight inner loop, however, so in this particular case the performance benefits from passing everything by reference outweigh the loss of readability.|
|[static GetMaxValueFromEnum<T>()](VRage.Utils.MyUtils@GetMaxValueFromEnum{T})||
|[static GetNormalVectorFromTriangle(ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetNormalVectorFromTriangle)||
|[static GetOpenBoundaries(Vector3[], Int32[], List<Vector3>)](VRage.Utils.MyUtils@GetOpenBoundaries)||
|[static GetPointLineDistance(ref Vector3D, ref Vector3D, ref Vector3D)](VRage.Utils.MyUtils@GetPointLineDistance)||
|[static GetPolyLineQuad(out MyQuadD, ref MyPolyLineD, Vector3D)](VRage.Utils.MyUtils@GetPolyLineQuad)||
|[static GetRandomBorderPosition(ref BoundingSphere)](VRage.Utils.MyUtils@GetRandomBorderPosition)||
|[static GetRandomBorderPosition(ref BoundingSphereD)](VRage.Utils.MyUtils@GetRandomBorderPosition)||
|[static GetRandomBorderPosition(ref BoundingBox)](VRage.Utils.MyUtils@GetRandomBorderPosition)||
|[static GetRandomBorderPosition(ref BoundingBoxD)](VRage.Utils.MyUtils@GetRandomBorderPosition)||
|[static GetRandomDiscPosition(ref Vector3D, double, ref Vector3D, ref Vector3D)](VRage.Utils.MyUtils@GetRandomDiscPosition)||
|[static GetRandomDiscPosition(ref Vector3D, double, double, ref Vector3D, ref Vector3D)](VRage.Utils.MyUtils@GetRandomDiscPosition)||
|[static GetRandomDouble(double, double)](VRage.Utils.MyUtils@GetRandomDouble)||
|[static GetRandomFloat()](VRage.Utils.MyUtils@GetRandomFloat)||
|[static GetRandomFloat(float, float)](VRage.Utils.MyUtils@GetRandomFloat)||
|[static GetRandomInt(int)](VRage.Utils.MyUtils@GetRandomInt)||
|[static GetRandomInt(int, int)](VRage.Utils.MyUtils@GetRandomInt)|Return random int in range of minValue to maxValue, the range of return values includes minValue but not maxValue|
|[static GetRandomItem<T>(this T[])](VRage.Utils.MyUtils@GetRandomItem{T})||
|[static GetRandomItemFromList<T>(this List<T>)](VRage.Utils.MyUtils@GetRandomItemFromList{T})||
|[static GetRandomLong()](VRage.Utils.MyUtils@GetRandomLong)||
|[static GetRandomPerpendicularVector(ref Vector3)](VRage.Utils.MyUtils@GetRandomPerpendicularVector)||
|[static GetRandomPerpendicularVector(ref Vector3D)](VRage.Utils.MyUtils@GetRandomPerpendicularVector)||
|[static GetRandomPosition(ref BoundingBox)](VRage.Utils.MyUtils@GetRandomPosition)||
|[static GetRandomPosition(ref BoundingBoxD)](VRage.Utils.MyUtils@GetRandomPosition)||
|[static GetRandomRadian()](VRage.Utils.MyUtils@GetRandomRadian)||
|[static GetRandomSign()](VRage.Utils.MyUtils@GetRandomSign)||
|[static GetRandomTimeSpan(TimeSpan, TimeSpan)](VRage.Utils.MyUtils@GetRandomTimeSpan)|Returns a random TimeSpan between begin (inclusive) and end (exclusive).|
|[static GetRandomVector3()](VRage.Utils.MyUtils@GetRandomVector3)|Returns a uniformly-distributed random vector from inside of a box (-1,-1,-1), (1, 1, 1)|
|[static GetRandomVector3CircleNormalized()](VRage.Utils.MyUtils@GetRandomVector3CircleNormalized)||
|[static GetRandomVector3D()](VRage.Utils.MyUtils@GetRandomVector3D)|Returns a uniformly-distributed random vector from inside of a box (-1,-1,-1), (1, 1, 1)|
|[static GetRandomVector3HemisphereNormalized(Vector3)](VRage.Utils.MyUtils@GetRandomVector3HemisphereNormalized)||
|[static GetRandomVector3MaxAngle(float)](VRage.Utils.MyUtils@GetRandomVector3MaxAngle)||
|[static GetRandomVector3Normalized()](VRage.Utils.MyUtils@GetRandomVector3Normalized)||
|[static GetSmallestDistanceToSphere(ref Vector3D, ref BoundingSphereD)](VRage.Utils.MyUtils@GetSmallestDistanceToSphere)|Calculates distance from point 'from' to boundary of 'sphere'. If point is inside the sphere, distance will be negative.|
|[static GetSmallestDistanceToSphereAlwaysPositive(ref Vector3D, ref BoundingSphereD)](VRage.Utils.MyUtils@GetSmallestDistanceToSphereAlwaysPositive)||
|[static GetSpherePlaneIntersection(ref BoundingSphereD, ref PlaneD, out double)](VRage.Utils.MyUtils@GetSpherePlaneIntersection)|This tells if a sphere is BEHIND, in FRONT, or INTERSECTS a plane, also it's distance|
|[static GetSpherePlaneIntersection(ref BoundingSphere, ref Plane, out float)](VRage.Utils.MyUtils@GetSpherePlaneIntersection)|This tells if a sphere is BEHIND, in FRONT, or INTERSECTS a plane, also it's distance|
|[static GetSphereTriangleIntersection(ref BoundingSphere, ref Plane, ref MyTriangle_Vertices)](VRage.Utils.MyUtils@GetSphereTriangleIntersection)|Method returns intersection point between sphere and triangle (which is defined by vertexes and plane). If no intersection found, method returns null. See below how intersection point can be calculated, because it's not so easy - for example sphere vs. triangle will hardly generate just intersection point... more like intersection area or something.|
|[static GetTransformNormalNormalized(Vector3D, ref MatrixD)](VRage.Utils.MyUtils@GetTransformNormalNormalized)||
|[static GetUIntFromString(string)](VRage.Utils.MyUtils@GetUIntFromString)||
|[static GetUIntFromString(string, uint)](VRage.Utils.MyUtils@GetUIntFromString)||
|[static GetULongFromString(string)](VRage.Utils.MyUtils@GetULongFromString)||
|[static GetVector3Scaled(Vector3D, float)](VRage.Utils.MyUtils@GetVector3Scaled)||
|[static HasValidLength(Vector3)](VRage.Utils.MyUtils@HasValidLength)||
|[static HasValidLength(Vector3D)](VRage.Utils.MyUtils@HasValidLength)||
|[static Init<T>(ref T)](VRage.Utils.MyUtils@Init{T})||
|[static InterlockedMax(ref int, int)](VRage.Utils.MyUtils@InterlockedMax)||
|[static InterlockedMax(ref long, long)](VRage.Utils.MyUtils@InterlockedMax)||
|[static IsEqual(float, float)](VRage.Utils.MyUtils@IsEqual)||
|[static IsEqual(Vector2, Vector2)](VRage.Utils.MyUtils@IsEqual)||
|[static IsEqual(Vector3, Vector3)](VRage.Utils.MyUtils@IsEqual)||
|[static IsEqual(Quaternion, Quaternion)](VRage.Utils.MyUtils@IsEqual)||
|[static IsEqual(QuaternionD, QuaternionD)](VRage.Utils.MyUtils@IsEqual)||
|[static IsEqual(Matrix, Matrix)](VRage.Utils.MyUtils@IsEqual)||
|[static IsLineIntersectingBoundingSphere(ref LineD, ref BoundingSphereD)](VRage.Utils.MyUtils@IsLineIntersectingBoundingSphere)|Check intersection between line and bounding sphere We don't use BoundingSphere.Contains(Ray ...) because ray doesn't have an end, but line does, so we need to check if line really intersects the sphere.|
|[static IsValid(Matrix)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(MatrixD)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(Vector3)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(Vector3D)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(Vector2)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(float)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(double)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(Vector3?)](VRage.Utils.MyUtils@IsValid)||
|[static IsValid(Quaternion)](VRage.Utils.MyUtils@IsValid)||
|[static IsValidNormal(Vector3)](VRage.Utils.MyUtils@IsValidNormal)||
|[static IsValidOrZero(Matrix)](VRage.Utils.MyUtils@IsValidOrZero)||
|[static IsWrongTriangle(Vector3, Vector3, Vector3)](VRage.Utils.MyUtils@IsWrongTriangle)||
|[static IsZero(float, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(double, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(Vector3, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(ref Vector3, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(Vector3D, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(ref Vector3D, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(Quaternion, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(ref Quaternion, float)](VRage.Utils.MyUtils@IsZero)||
|[static IsZero(Vector4)](VRage.Utils.MyUtils@IsZero)||
|[static LinePlaneIntersection(Vector3D, Vector3, Vector3D, Vector3)](VRage.Utils.MyUtils@LinePlaneIntersection)||
|[static Normalize(Vector3)](VRage.Utils.MyUtils@Normalize)|Protected normalize with assert|
|[static Normalize(Vector3D)](VRage.Utils.MyUtils@Normalize)||
|[static Normalize(ref Vector3, out Vector3)](VRage.Utils.MyUtils@Normalize)|Protected normalize with assert|
|[static Normalize(ref Vector3D, out Vector3D)](VRage.Utils.MyUtils@Normalize)||
|[static Normalize(ref Matrix, out Matrix)](VRage.Utils.MyUtils@Normalize)|Protected normalize with assert|
|[static Normalize(ref MatrixD, out MatrixD)](VRage.Utils.MyUtils@Normalize)||
|[static PrepareCollection<TCollection, TElement>(ref TCollection)](VRage.Utils.MyUtils@PrepareCollection{TCollection,TElement})||
|[static ReuseCollection<TElement>(ref List<TElement>)](VRage.Utils.MyUtils@ReuseCollection{TElement})||
|[static ReuseCollection<TElement>(ref MyList<TElement>)](VRage.Utils.MyUtils@ReuseCollection{TElement})||
|[static ReuseCollection<TElement>(ref HashSet<TElement>)](VRage.Utils.MyUtils@ReuseCollection{TElement})||
|[static ReuseCollection<TKey, TValue>(ref Dictionary<TKey, TValue>)](VRage.Utils.MyUtils@ReuseCollection{TKey,TValue})||
|[static ReuseCollection<TCollection, TElement>(ref TCollection)](VRage.Utils.MyUtils@ReuseCollection{TCollection,TElement})||
|[static ReuseCollectionNested<TElement>(ref List<TElement>)](VRage.Utils.MyUtils@ReuseCollectionNested{TElement})||
|[static RotationMatrixToYawPitchRoll(ref Matrix, out float, out float, out float)](VRage.Utils.MyUtils@RotationMatrixToYawPitchRoll)||
|[static RotationMatrixToYawPitchRoll(ref MatrixD, out double, out double, out double)](VRage.Utils.MyUtils@RotationMatrixToYawPitchRoll)||
|[static SerializeValue(XmlWriter, Vector3)](VRage.Utils.MyUtils@SerializeValue)||
|[static SerializeValue(XmlWriter, Vector4)](VRage.Utils.MyUtils@SerializeValue)||
|[static ShuffleList<T>(this IList<T>, int, int?)](VRage.Utils.MyUtils@ShuffleList{T})||
|[static StripInvalidChars(string)](VRage.Utils.MyUtils@StripInvalidChars)||
|[static Swap<T>(ref T, ref T)](VRage.Utils.MyUtils@Swap{T})||
|[static TryParseWithSuffix(this string, NumberStyles, IFormatProvider, out float, Tuple`2[])](VRage.Utils.MyUtils@TryParseWithSuffix)||
|[static VectorPlaneRotation(Vector3D, Vector3D, out Vector3D, out Vector3D, float)](VRage.Utils.MyUtils@VectorPlaneRotation)||

