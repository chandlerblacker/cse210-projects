using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture l1 = new Lecture("Stake Youth Fireside", "All youth are invited to come and listen to our guest speaker", "09-17-23", "6:00 pm", "143 Bowser Blvd", "Richardson", "TX", "USA", "Brother Ward", 150);
        l1.printShort();
        l1.printStandard();
        l1.printFull();

        Reception r1 = new Reception("Bruce and Emily's Wedding Reception", "Come party with us as we celebrate Bruce and Emily's wedding!", "07-22-23", "7-9:30 pm", "564 North Lake Rd", "Boise", "Idaho", "USA", "emilybrown@gmail.com");
        r1.printShort();
        r1.printStandard();
        r1.printFull();

        Outdoor o1 = new Outdoor("Barch's Summer BBQ", "Bring your family! There will be games, swimming, and of course plenty of food!", "06-30-23", "12-3:00 pm", "123 Watersedge Way", "Wylie", "Oklahoma", "USA", "Sunny and clear!");
        o1.printShort();
        o1.printStandard();
        o1.printFull();
    }
}