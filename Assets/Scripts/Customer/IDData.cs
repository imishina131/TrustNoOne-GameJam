using UnityEngine;

public class IDData
{
    private Color _eyeColor;
    private Color _hairColor;
    private Color _skinColor;
    private string _customerName;
    private int _customerHeight;


    public IDData(Color eyeColor, Color hairColor, Color skinColor, string customerName,  int customerHeight)
    {
        EyeColor = eyeColor;
        HairColor = hairColor;
        SkinColor = skinColor;
        CustomerName = customerName;
        CustomerHeight = customerHeight;
    }
    
    
    public Color EyeColor
    {
        get { return _eyeColor; }
        private set { _eyeColor = value; }
    }
    public Color HairColor
    {
        get { return _hairColor; }
        private set { _hairColor = value; }
    }
    public Color SkinColor
    {
        get { return _skinColor; }
        private set { _skinColor = value; }
    }
    public string CustomerName
    {
        get { return _customerName; }
        private set { _customerName = value; }
    }
    public int CustomerHeight
    {
        get { return _customerHeight; }
        private set { _customerHeight = value; }
    }
}
