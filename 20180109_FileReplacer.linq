<Query Kind="Statements" />

// 파일, 폴더별 용량 체크
var gatherPath = @"C:\Users\sydne\Desktop\TestFile";	// 끌어모을 대상 폴더
var destPath = @"C:\Users\sydne\Desktop\origin";        //	목표 폴더 
var ext = new List<string>{@""};	// 목표 파일 확장자


// 폴더 리커시브하게 돌면서 특정 확장자를 가진 파일만 destPath로 이동

