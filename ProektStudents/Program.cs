using ProektStudents;

Student s = new Student();

Lector l = new Lector();

Room room = new Room();

room.Enter(l);
room.Enter(s);

l.Say(room, "Good Morning!");