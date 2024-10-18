using Proekt1;
using static System.Console;



MatrixDefault md = new MatrixDefault(5,5);

MatrixSparse ms = new MatrixSparse(5,5);

MatrixInit.Init(md, 25, 10);
MatrixInit.Init(ms, 12, 10);

MatrixStatistic matSt = new MatrixStatistic(md);
WriteLine("Matrix 1:");
Printer.Print(md);
WriteLine("Notnull: " + matSt.Notnull);
WriteLine("Sum: " + matSt.Sum);
WriteLine("Max: " + matSt.Max);
WriteLine("Avg: " + matSt.Avg);
WriteLine();


matSt = new MatrixStatistic(ms);
WriteLine("Matrix 2:");
Printer.Print(ms);
WriteLine("Notnull: " + matSt.Notnull);
WriteLine("Sum: " + matSt.Sum);
WriteLine("Max: " + matSt.Max);
WriteLine("Avg: " + matSt.Avg);



