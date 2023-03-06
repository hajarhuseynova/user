class User
{
    private string _userName;
    private string _password;

 public string UserName
    {
        get
        { return _userName; }
        set
        {
            if (!value.Contains(" "))
            {
                _userName = value;
            }
        }
    }
    
    public string Password
    {
        get
        { return _password; }
        set
        {
            if (CheckPassword(value))
            {
                _password = value;
            }
           
        }
    }
    public User (string UserName, string Password)
    {
        if (CheckPassword(Password))
        {

            this.UserName = UserName;
            this.Password = Password;
        }
    }

    public bool CheckPassword(string value)
    {
        if (!(value.Length >= 8))
        {
            return false;
        }
        if (value.Contains(" "))
        {
            return false;
        }
        if (true)
        {
            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                string digits = i.ToString();
                if (value.Contains(digits))
                {
                    count = 1;
                }
            }
            if (count == 0)
            {
                return false;
            }
        }
        if (true)
        {
            int count = 0;
            for (int i = 65; i <= 90; i++)
            {
                char c = (char)i;
                string letters = c.ToString();
                if (value.Contains(letters))
                {
                    count = 1;
                }
            }
            if (count == 0)
            {
                return false;
            }
        }
        return true;
    }

}