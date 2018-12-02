namespace json_parser
{
  class User
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Website { get; set; }

    public override string ToString()
    {
      return $"ID: {Id}, Name: {Name}";
    }

  }
}