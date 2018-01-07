<Query Kind="Statements" />

// 파일, 폴더별 용량 체크
var path = @"E:\";

Directory.GetFiles(path)
.Select(e => new FileInfo(e))
.Select(e => new { Name = e.Name, DataLength = e.Length})
.OrderByDescending(e => e.DataLength)
.Dump();
