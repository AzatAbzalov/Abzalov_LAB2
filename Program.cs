Person i = new();
i.OutAll();
i = new("Абзалов", "Азат", Convert.ToDateTime("02.02.2005"), 'М');
i.OutAll();
Person i1 = new(i);
i1.OutAll();

Console.Write("Введите кол-во пользователей: ");
int x = Convert.ToInt32(Console.ReadLine());
Person[] array = new Person[x];
for (int j = 0; j < x; j++)
    array[j] = new Person();
for (int j = 0; j < x; j++)
    array[j].OutAll();




class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime Birth { get; set; }
    private char sex;

    public char Sex
    {
        get { return sex; }
        private set
        {
            if (value != 'М' & value != 'Ж')
                Console.WriteLine("Введите символ М или Ж");
            else sex = value;
        }

    }


    public Person()
    {
        FirstName = InpFirstName();
        LastName = InpLastName();
        Birth = InpBirth();
        Sex = InpSex();
        Console.WriteLine();

    }
    public Person(Person person) : this(person.FirstName, person.LastName, person.Birth, person.Sex)
    { }
    public Person(string firstName = " ", string lastName = " ", DateTime birth = new(), char sex = ' ')
    {
        FirstName = firstName;
        LastName = lastName;
        Birth = birth;
        Sex = sex;


    }
    public string ToString(object smth) { return Convert.ToString(smth); }
    public void Out(object smth) { Console.WriteLine(ToString(smth)); }
    public void OutAll()
    {
        Console.Write("Фамилия: ");  Out(FirstName);
        Console.Write("Имя: "); Out(LastName);
        Console.Write("Дата рождения: "); Out(Birth);
        Console.Write("Пол: "); Out(sex);
        Console.Write("Возраст: "); Out(Age());
        Console.WriteLine();
    }
       
    public string InpFirstName()
    {
        Console.Write("Введите фамилию: ");
        return Console.ReadLine();
    }
    public string InpLastName() 
    {
        Console.Write("Введите имя: ");
        return Console.ReadLine();
    }
    public DateTime InpBirth()
    {
        Console.Write("Введите дату рождения: ");
        return Convert.ToDateTime(Console.ReadLine());
    }
    public char InpSex() 
    {
        Console.Write("Введите пол: ");
        return Convert.ToChar(Console.ReadLine());
    }
    public int Age()
    {
        DateTime now = DateTime.Now;
        int age = now.Year - Birth.Year;
        if (Birth > now.AddYears(-age)) age--;
        return age;
    }
   
            
             
}