using Proekt1;
using Proekt1.Tools;
using static System.Console;



MatrixDefault md = new MatrixDefault(5,5);

MatrixSparse ms = new MatrixSparse(5,5);

MatrixInit.Init(md, 25, 10);
MatrixInit.Init(ms, 12, 10);

MatrixStatistic matSt = new MatrixStatistic(md);
WriteLine("Matrix 1:");
PrinterOld.Print(md);
WriteLine("Notnull: " + matSt.Notnull);
WriteLine("Sum: " + matSt.Sum);
WriteLine("Max: " + matSt.Max);
WriteLine("Avg: " + matSt.Avg);
WriteLine();

md.Print(new ConsolePrinter());


/*matSt = new MatrixStatistic(ms);
WriteLine("Matrix 2:");
PrinterOld.Print(ms);
WriteLine("Notnull: " + matSt.Notnull);
WriteLine("Sum: " + matSt.Sum);
WriteLine("Max: " + matSt.Max);
WriteLine("Avg: " + matSt.Avg);*/



