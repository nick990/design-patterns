using Pegs;

var roundPeg1 = new RoundPeg(5);
var roundPeg2 = new RoundPeg(10);
var squarePag1 = new SquarePeg(5);
var squarePag2 = new SquarePeg(10);
var roundHole = new RoundHole(5);
Console.WriteLine($"Does a round peg of radius {roundPeg1.GetRadius()} fit a round hole of radius {roundHole.Radius}?");
Console.WriteLine(roundHole.Fits(roundPeg1));
Console.WriteLine($"Does a round peg of radius {roundPeg2.GetRadius()} fit a round hole of radius {roundHole.Radius}?");
Console.WriteLine(roundHole.Fits(roundPeg2));
Console.WriteLine($"Does a square peg of width {squarePag1.GetWidth()} fit a round hole of radius {roundHole.Radius}?");
Console.WriteLine(roundHole.Fits(new SquarePegAdapter(squarePag1)));
Console.WriteLine($"Does a square peg of width {squarePag2.GetWidth()} fit a round hole of radius {roundHole.Radius}?");
Console.WriteLine(roundHole.Fits(new SquarePegAdapter(squarePag2)));
