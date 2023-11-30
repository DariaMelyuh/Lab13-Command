namespace Lab13_Command
{
    class OpenDoorCommand : ICommand
    {
        private Door _door;

        public OpenDoorCommand(Door door)
        {
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Дверь не может быть равен null.");
            }

            this._door = door;
        }

        public void Execute()
        {
            _door.Open();
        }
    }
}
