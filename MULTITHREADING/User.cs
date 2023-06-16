namespace MULTITHREADING
{
    internal class User
    {
        public string Name { get; set; }              // Provides the name of the thread object.
        public bool IsAlive { get; }                      // Provides whether the thread object is alive.
                                                          // It is a read-only property.
        public ThreadState ThreadState { get; }           // Provides the state of the thread. 
        public ThreadPriority Priority { get; set; }      //public ThreadPriority Priority { get; set; }

    }
}
