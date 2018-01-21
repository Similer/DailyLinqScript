<Query Kind="Program" />

void Main()
{
	// 파일, 폴더별 용량 체크
	var path = @"C:\Users\lyk16\Desktop\새 폴더";
	var destPath = @"C:\Users\lyk16\Desktop\새 폴더\target";

	if (Directory.Exists(path) == false || Directory.Exists(destPath) == false)
	{
		"Path error".Dump();
		return;
	}

	var targetExt = new List<string>{
	".avi",
	".mkv",
	".flv",
	".wmv",
	".asf",
	".mp4",
	".mpg",
	".mpeg",
	".m4v",	
	".webm",	
	};

	var fileInfo = GetFileInfo(path)
	.Where(e => targetExt.Contains(e.Extension))
	.ToList();
	
	foreach(var info in fileInfo)
	{
		var newName = destPath + @"\" + info.Name;

		//  같은 경로 복사면 넘기자
		if (info.FullName == newName)
			continue;

		// 같은 이름의 파일이 존재하면 Rename
		if (File.Exists(newName))
			newName = newName.Remove(newName.Length - info.Extension.Length) + "_renamed" + info.Extension;
		
		File.Move(info.FullName, newName);
	}
	
}

// Define other methods and classes here
List<FileInfo> GetFileInfo(string path)
{
	var result = new List<FileInfo>();
	
	var subDirectories = Directory.GetDirectories(path);
	if (subDirectories.Count() != 0)
	{
		foreach (var dir in subDirectories)
		{
			result.AddRange(GetFileInfo(dir));
		}
	}	
	
	result.AddRange(Directory.GetFiles(path).Select(e => new FileInfo(e)).ToList());
	
	return result;
}