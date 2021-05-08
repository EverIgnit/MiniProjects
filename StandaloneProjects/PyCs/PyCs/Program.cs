using IronPython.Hosting;
using RPG.Entities.Creatures.Monsters;
var file = @"..\..\..\..\IronPythonApplication1\IronPythonApplication1.py";
var pygine = Python.CreateEngine();
dynamic script = pygine.ExecuteFile(file);
script.DelDmgTo(new Vampire("Fedya"));