<Query Kind="Statements" />

// 파일, 폴더별 용량 체크
var path = @"C:\Users\sydne\Desktop\TestFile";
var originPath = @"C:\Users\sydne\Desktop\origin";

var fileInfo = Directory.GetFiles(originPath)
.Select(e => new FileInfo(e))
.ToList();

foreach (var file in fileInfo)
{
	file.FullName.Dump();
	File.Move(file.FullName, path + @"\" + file.Name);
	// File.Delete(file.Name);
}