namespace Lab13_Command
{
    class CloseDoorCommand : ICommand
    {
        private Door door;

        public CloseDoorCommand(Door door)
        {
            this.door = door;
        }

        public void Execute()
        {
            door.Close();
        }

       
    }
}
