# HTML-Builder
A Html Builder created Using C#

# HOW TO USE

```C#
using HTMLBuilder;

public static void Main(string[] args) {
   Builder builder = new Builder();
   builder.Build() // Writes the build
}
```

   **ALT**
   
```C#
using HTMLBuilder;

public static void Main(string[] args) {
   Builder builder = new Builder();
   string output = builder.Build(true); // Returns a string
   Console.WriteLine(output);
}
```
