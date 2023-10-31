
#region Directory and DirectoryInfo

var folderName = "pasta";
var subFolderName = "subpasta";
var subFolderNameStatic = "subpasta_usingstatic";

var directoryInfoSubFolder = new DirectoryInfo(subFolderName);
if (!Directory.Exists(subFolderName) || !directoryInfoSubFolder.Exists)
{
    Directory.CreateDirectory(subFolderNameStatic);
    Directory.CreateDirectory(folderName);
    directoryInfoSubFolder.Create();

    directoryInfoSubFolder.MoveTo($"{folderName}//{subFolderName}");
    Directory.Move(subFolderNameStatic, @$"{folderName}\{subFolderNameStatic}");
}

var name = directoryInfoSubFolder.Name;
var parent = directoryInfoSubFolder.Parent;
var root = directoryInfoSubFolder.Root;
var exists = directoryInfoSubFolder.Exists;

foreach (var directory in Directory.GetDirectories(folderName))
{
    Console.WriteLine(directory);
}

Directory.Delete($@"{folderName}/{subFolderName}");

#endregion

Console.ReadKey();
