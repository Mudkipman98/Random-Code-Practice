## I'm Doing Markdown Practice Too

Why does Markdown read like English?  Maybe it's just because I'm now realizing that loads of websites and web apps have markdown support, but like...

Am I stupid?  Because this seems really easy.

>I can do the discord quote thing.

1. And lists are a joke.  They're just
2. Written like an actual list
    1. That you would type
    2. In order
    3. with NUMBERS
3. AAAAAHHHHHHHHHHHHHHH

###### Anyway...

Here's a place to dump shit while I learn.

I think I've got the syntax of this class inheritance in C# down.  Can anyone confirm?

```
public class PracticeClass
{
    string content;
    

    //Properties (protected should mean that each property is private except for derived classes, those can set it)
    public string Content {get; protected set;}
    

    //Constructor in C#
    public PracticeClass()
    {
        this.Content = content;
        
    }

    public void Print()
    {
        Console.WriteLine(Content);
    }

    public string Write(string i)
    {
        this.Content = i;
    }
}

public class MorePractice : PracticeClass
{
    //because this class is inheriting PracticeClass, it should have access to all of the code in that class too.  And because the Content property is 'protected' code in this class can edit instances of it when it's used.
}