using System; 
namespace MatrixManipulation 
{ 
    class Matrix
    { 
        static void Main() 
        { 
            // Create random matrices 
            int[,] matrix1 = CreateRandomMatrix(3, 3); 
            int[,] matrix2 = CreateRandomMatrix(3, 3); 
 
            // Display matrices 
            Console.WriteLine("Matrix 1:"); 
            DisplayMatrix(matrix1); 
            Console.WriteLine("Matrix 2:"); 
            DisplayMatrix(matrix2); 
 
            // Add matrices 
            int[,] sumMatrix = AddMatrices(matrix1, matrix2); 
            Console.WriteLine("Sum of matrices:"); 
            DisplayMatrix(sumMatrix); 
 
            // Subtract matrices 
            int[,] diffMatrix = SubtractMatrices(matrix1, 
matrix2); 
            Console.WriteLine("Difference of matrices:"); 
            DisplayMatrix(diffMatrix); 
// Multiply matrices 
int[,] productMatrix = MultiplyMatrices(matrix1, 
matrix2); 
Console.WriteLine("Product of matrices:"); 
DisplayMatrix(productMatrix); 
// Transpose matrix 
int[,] transposeMatrix = TransposeMatrix(matrix1); 
Console.WriteLine("Transpose of Matrix 1:"); 
DisplayMatrix(transposeMatrix); 
// Determinant of 2x2 matrix 
int[,] matrix2x2 = CreateRandomMatrix(2, 2); 
Console.WriteLine("2x2 Matrix:"); 
DisplayMatrix(matrix2x2); 
double determinant2x2 = Determinant2x2(matrix2x2); 
Console.WriteLine("Determinant of 2x2 matrix: " + 
determinant2x2); 
// Determinant of 3x3 matrix 
double determinant3x3 = Determinant3x3(matrix1); 
Console.WriteLine("Determinant of 3x3 matrix: " + 
determinant3x3); 
} 
// Inverse of 2x2 matrix 
double[,] inverse2x2 = Inverse2x2(matrix2x2); 
Console.WriteLine("Inverse of 2x2 matrix:"); 
DisplayMatrix(inverse2x2); 
// Inverse of 3x3 matrix 
double[,] inverse3x3 = Inverse3x3(matrix1); 
Console.WriteLine("Inverse of 3x3 matrix:"); 
DisplayMatrix(inverse3x3); 
static int[,] CreateRandomMatrix(int rows, int cols) 
{ 
Random random = new Random(); 
int[,] matrix = new int[rows, cols]; 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
matrix[i, j] = random.Next(1, 10); 
} 
} 
return matrix; 
} 
static int[,] AddMatrices(int[,] matrix1, int[,] matrix2) 
{ 
int rows = matrix1.GetLength(0); 
int cols = matrix1.GetLength(1); 
int[,] result = new int[rows, cols]; 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
result[i, j] = matrix1[i, j] + matrix2[i, j]; 
} 
} 
return result; 
} 
matrix2) 
{ 
static int[,] SubtractMatrices(int[,] matrix1, int[,] 
int rows = matrix1.GetLength(0); 
int cols = matrix1.GetLength(1); 
int[,] result = new int[rows, cols]; 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
result[i, j] = matrix1[i, j] - matrix2[i, j]; 
} 
} 
return result; 
} 
static int[,] MultiplyMatrices(int[,] matrix1, int[,] 
matrix2)  
{ 
} 
int rows = matrix1.GetLength(0); 
int cols = matrix2.GetLength(1); 
int[,] result = new int[rows, cols]; 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
result[i, j] = 0; 
for (int k = 0; k < matrix1.GetLength(1); k++) 
{ 
result[i, j] += matrix1[i, k] * matrix2[k,j]; 
} 
} 
} 
return result; 
static int[,] TransposeMatrix(int[,] matrix) 
{ 
int rows = matrix.GetLength(0); 
int cols = matrix.GetLength(1); 
int[,] result = new int[cols, rows]; 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
result[j, i] = matrix[i, j]; 
} 
} 
return result; 
} 
static double Determinant2x2(int[,] matrix) 
{ 
return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * 
matrix[1, 0]; 
} 
static double Determinant3x3(int[,] matrix) 
{ 
double determinant = 0; 
for (int i = 0; i < 3; i++) 
{ 
determinant += (matrix[0, i] * (matrix[1, (i + 1) 
% 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, 
(i + 1) % 3])); 
} 
return determinant; 
} 
static double[,] Inverse2x2(int[,] matrix) 
{ 
double determinant = Determinant2x2(matrix); 
if (determinant == 0) 
{ 
throw new InvalidOperationException("Matrix is not 
invertible."); 
} 
double[,] result = new double[2, 2]; 
result[0, 0] = matrix[1, 1] / determinant; 
result[0, 1] = -matrix[0, 1] / determinant; 
result[1, 0] = -matrix[1, 0] / determinant; 
result[1, 1] = matrix[0, 0] / determinant; 
return result; 
} 
static double[,] Inverse3x3(int[,] matrix) 
{ 
double determinant = Determinant3x3(matrix); 
if (determinant == 0) 
{ 
throw new InvalidOperationException("Matrix is not 
invertible."); 
} 
double[,] result = new double[3, 3]; 
for (int i = 0; i < 3; i++) 
{ 
for (int j = 0; j < 3; j++) 
{ 
result[i, j] = ((matrix[(j + 1) % 3, (i + 1) % 
3] * matrix[(j + 2) % 3, (i + 2) % 3]) - (matrix[(j + 1) % 3, (i + 
2) % 3] * matrix[(j + 2) % 3, (i + 1) % 3])) / determinant; 
} 
} 
return result; 
} 
static void DisplayMatrix(int[,] matrix) 
{ 
int rows = matrix.GetLength(0); 
int cols = matrix.GetLength(1); 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
Console.Write(matrix[i, j] + " "); 
} 
Console.WriteLine(); 
} 
} 
} 
static void DisplayMatrix(double[,] matrix) 
{ 
int rows = matrix.GetLength(0); 
int cols = matrix.GetLength(1); 
for (int i = 0; i < rows; i++) 
{ 
for (int j = 0; j < cols; j++) 
{ 
Console.Write(matrix[i, j] + " "); 
} 
Console.WriteLine();
}
}
}
}