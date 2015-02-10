# PHANTOM .NET #
> This version of Phantom uses Microsoft® technologies. 

It is a software for the management of the archives physicists who are created in the different departments of a company, these files will be scanned and stored through PHANTOM to generate a record, complete, detailed, and safe. 

## Architecture ##
This project to been structured in 5 layers, each layer components may interact with components from lower layers or components of the same layer.

### Layers ###
1. Data  
2. Domain
3. Application
4. Distributed Services
5. Presentation

### Technical Structure ###
.NET Framewrok: 4.5
IDE: Visual Studio 2013 Update 4

1. Data
    * C# Class Library
2. Domain
    * C# Class Library
3. Application
    * C# Class Library
4. Distributed Services
    * ASP.NET Web API
5. Presentations
    * ASP.NET MVC
 

### Test ###
The good practice of performing tests will be carried out under the BDD, specifically for. NET, using the tool [SpecFlow](http://www.specflow.org/).

## Contributions ##
If you want to share a best practice of design, structure or code, that I have not followed, please let me know by opening an issue on the issue tracker.
This project is complety open to pull requests :).

## License ##
Phantom is released under the [MIT license](http://opensource.org/licenses/MIT):

```
The MIT License (MIT)

Copyright (c) 2015 John Alejandro Mantilla Celis 

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
```

