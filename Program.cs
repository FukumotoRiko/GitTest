namespace gittest
{

    class Person
    {
        //属性
        private String name;
        private Birthday date;
        private Gender gender;
        private double age;

        //构造器
        public Person(String name,String birthday,Gender gender){
            this.name = name;

            setBirthday(birthday);

            this.age = date.getAge();

            this.gender = gender;
        
        }

        //方法
        private void setBirthday(String birthday)
        {
            string[] buffer = new string[3];
            int end = 0;
            int begin = 0;
            int i = 0;
            while(end != -1)
            {
                end = birthday.IndexOf(".",begin);
                int length = end - begin;
                if (end == -1)
                {
                    length = birthday.Length - begin;   
                }
                buffer[i] = birthday.Substring(begin, length);//Substring()后面参数不是角标位置，是截取长度
                begin = end + 1;
                i++;

            }

            date = new Birthday(int.Parse(buffer[0]), int.Parse(buffer[1]), int.Parse(buffer[2]));
        }

        public override string ToString()
        {
            return "name:" + name + "\tbirthday:" + date.ToString() + "\tgender:" + gender + "\tage:" + age;
        }

        public void showEat()
        {
            Console.WriteLine(name + "开始吃饭");
        }

        public void showWalk()
        {
            Console.WriteLine(name + "开始走路");
        }

        public void showTalk()
        {
            Console.WriteLine(name + "开始说话");
        }

    }

    //性别枚举类
    public enum Gender
    {
        MALE,
        FEMALE,
        NULL
    }

    //出生年月类
   class Birthday
    {
        private int year;
        private int month;
        private int day;

        //构造器
        public Birthday(int year,int month,int day){
            this.year = year;
            this.month = month;
            this.day = day;
        }

        //重写toString方法
        public override String ToString() {
            return year + "." + month + "." + day;
        }

        //获取年龄方法
           public double getAge()
        {
            int nowYear = DateTime.Now.Year;
            int nowMonth = DateTime.Now.Month;

            double ageYear = Math.Round((nowYear - year*1.0),1);
            double ageMonth = Math.Round((month / 12.0),1);

            double age = ageYear + ageMonth;

            return age;
        }

        
    }

    /*public Person(String name, String birthday, Gender gender)*/
/*    public Birthday(int year, int month, int day)*/

    class Test
    {
        static void Main(String[] str)
        {
            Person p1 = new Person("Tom","1999.8.7",Gender.MALE);
            Person p2 = new Person("Jenny", "2000.4.7", Gender.FEMALE);
            Person p3 = new Person("GoGo", "2000.4.7", Gender.FEMALE);
            Person p4 = new Person("Bob", "2000.4.7", Gender.FEMALE);
            Person p5 = new Person("Alex", "2000.5.8", Gender.MALE);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            p1.showEat();
            p1.showTalk();
            p1.showWalk();

            p2.showEat();
            p2.showTalk();
            p2.showWalk();
        }
    }

}
