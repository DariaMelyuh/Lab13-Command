namespace Lab13_Command
{
    class CloseDoorCommand : ICommand
    {
        private Door door;

        public CloseDoorCommand(Door door)
        {
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Дверь не может быть равна null.");
            }

            this.door = door;
        }

        public void Execute()
        {
            door.Close();
        }
    }
}
