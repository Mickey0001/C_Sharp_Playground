using OpenQA.Selenium;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

public class NullWebElement : IWebElement
{
    private const string nullWebElement = "NullWebElement";

    public string TagName { get { return nullWebElement; } }
    public string Text { get { return nullWebElement; } }
    public bool Enabled { get { return false; } }
    public bool Selected { get { return false; } }
    public Point Location { get { return new Point(0, 0); } }
    public Size Size { get { return new Size(0, 0); } }
    public bool Displayed { get { return false; } }
    public void Clear() { }
    public void Click() { }
    public string GetAttribute(string attributeName) { return nullWebElement; }
    public string GetCssValue(string propertyName) { return nullWebElement; }
    public string GetProperty(string propertyName) { return nullWebElement; }
    public void SendKeys(string text) { }
    public void Submit() { }

    public IWebElement FindElement(By by) { return this; }
    public ReadOnlyCollection FindElements(By by)
    {
        return new ReadOnlyCollection(new List());
    }

    private NullWebElement() { }

    private static NullWebElement instance;
    public static NullWebElement NULL
    {
        get
        {
            if (instance == null)
            {
                instance = new NullWebElement();
            }
            return instance;
        }
    }
}