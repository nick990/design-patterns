using VideoConverter;

var videoConverter = new SimpleVideoConverter();
var sourceFileName = "funny-video.ogg";
var destinationFormat = "mp4";
Console.WriteLine($"Converting '{sourceFileName}' to format '{destinationFormat}'");
var resultFile = videoConverter.Convert(sourceFileName, destinationFormat);
Console.WriteLine("VideoConversion complete. Result file: " + resultFile.FileName);
Console.WriteLine("-------------------------");
sourceFileName = "cool-video.mp4";
destinationFormat = "ogg";
Console.WriteLine($"Converting '{sourceFileName}' to format '{destinationFormat}'");
resultFile = videoConverter.Convert(sourceFileName, destinationFormat);
Console.WriteLine("VideoConversion complete. Result file: " + resultFile.FileName);