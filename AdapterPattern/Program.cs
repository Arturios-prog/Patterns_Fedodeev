﻿using AdapterPattern;

ITarget target = new Adapter(new Adaptee());

Console.WriteLine(target.GetRequest()); // Output: "This is 'Specific request.'"
