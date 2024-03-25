
using DesignPatterns.Momento;

var player = new Player();

player.GoForward();
player.GoForward();
player.GoForward();
player.GoBack();
player.GoBack();
player.GoForward();
player.GoForward();
player.GoBack();

Console.ReadLine();
