<Query Kind="Statements" />



var path = @"C:\Users\lyk1629\Desktop";


foreach (var file in Directory.GetFiles(path))
{
	file.Dump();
}
