using RemoteController;
using RemoteController.Commands;
using RemoteController.Receivers;

var LightLiving = new Light("Living Room");
var LightLivingOn = new LightOnCommand(LightLiving);
var LightLivingOff = new LightOffCommand(LightLiving);

var LightKitchen = new Light("Kitchen");
var LightKitchenOn = new LightOnCommand(LightKitchen);
var LightKitchenOff = new LightOffCommand(LightKitchen);

var StereoBedroom = new Stereo("Bedroom");
var StereoBedroomOnWithCD = new StereoOnWithCDCommand(StereoBedroom);
var StereoBedroomOff = new StereoOffCommand(StereoBedroom);


var MacroOn = new MacroCommand(new List<ICommand> { LightLivingOn, LightKitchenOn, StereoBedroomOnWithCD });
var MacroOff = new MacroCommand(new List<ICommand> { LightLivingOff, LightKitchenOff, StereoBedroomOff });

var remote = new RemoteControl();
remote.SetCommand(0, LightLivingOn, LightLivingOff);
remote.SetCommand(1, LightKitchenOn, LightKitchenOff);
remote.SetCommand(2, StereoBedroomOnWithCD, StereoBedroomOff);
remote.SetCommand(3, MacroOn, MacroOff);

Console.WriteLine(remote);
Console.WriteLine("------ Pushing On Button [0] ------");
remote.OnButtonWasPushed(0);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing Off Button [0] ------");
remote.OffButtonWasPushed(0);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing Undo Button ------");
remote.UndoButtonWasPushed();
Console.WriteLine(remote);
Console.WriteLine("------ Pushing On Button [1] ------");
remote.OnButtonWasPushed(1);
Console.WriteLine("------ Pushing Off Button [1] ------");
remote.OffButtonWasPushed(1);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing On Button [2] ------");
remote.OnButtonWasPushed(2);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing Undo Button ------");
remote.UndoButtonWasPushed();
Console.WriteLine(remote);
Console.WriteLine("------ Pushing On Button [3] ------");
remote.OnButtonWasPushed(3);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing Off Button [3] ------");
remote.OffButtonWasPushed(3);
Console.WriteLine(remote);
Console.WriteLine("------ Pushing Undo Button ------");
remote.UndoButtonWasPushed();
Console.WriteLine(remote);