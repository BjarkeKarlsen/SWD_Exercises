using Lesson_6_Exercise5_1;

var flashlight = new Flashlight();

Console.WriteLine("Chaning flashlight event does always change from off to on if flashlight " +
    "\nis turn off even if it is only mode that changes\n");

Console.WriteLine("Chaning flashlight event of power");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.POWER);


Console.WriteLine("\nChaning flashlight event of mode");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.MODE);

Console.WriteLine("\nChaning flashlight event of mode");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.MODE);


Console.WriteLine("\nChaning flashlight event of power");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.POWER);

Console.WriteLine("\nChaning flashlight event of mode");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.MODE);

Console.WriteLine("\nChaning flashlight event of mode");
flashlight.FlaslightEventHandler(Flashlight.FlashLightEvent.MODE);
