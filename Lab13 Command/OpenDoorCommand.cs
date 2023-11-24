namespace Lab13_Command
{
    class OpenDoorCommand : ICommand
    {
        private Door door;

        public OpenDoorCommand(Door door)
        {
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Дверь не может быть равен null.");
            }

            this.door = door;
        }

        public void Execute()
        {
            door.Open();
        }

    }
}
