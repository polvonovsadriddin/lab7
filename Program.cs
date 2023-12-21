class Person

{
    public string? Name { get; set; }
    public virtual int Age
    { get { return Age; }
        set { if (value >= 0 && value <= 100) Age = value; }


    }
  

    public virtual bool IsMarried { get; private set; }

   
}
