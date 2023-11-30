namespace Lab13_Command
{
    class CloseDoorCommand : ICommand
    {
        private Door _door;

        public CloseDoorCommand(Door door)
        {
            if (door == null)
            {
                throw new ArgumentNullException(nameof(door), "Дверь не может быть равна null.");
            }

            this._door = door;
        }

        public void Execute()
        {
            _door.Close();
        }
    }
}
