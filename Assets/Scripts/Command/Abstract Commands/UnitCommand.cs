using Command.Player;

namespace Command.Commands
{
    /// <summary>
    /// An abstract class representing a unit-related command.
    /// </summary>
    public abstract class UnitCommand : ICommand
    {
        // Struct to store information related to the command.
        public CommandData commandData;

        // References to the actor and target units, accessible by subclasses.
        protected UnitController actorUnit;
        protected UnitController targetUnit;

        /// <summary>
        /// Abstract method to execute the unit command. Must be implemented by concrete subclasses.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Abstract method to undo the unit command. Must be implemented by concrete subclasses.
        /// </summary>
        public abstract void Undo();

        /// <summary>
        /// Abstract method to determine whether the command will successfully hit its target.
        /// Must be implemented by concrete subclasses.
        /// </summary>
        public abstract bool WillHitTarget();

        // Setters
        public void SetActorUnit(UnitController actorUnit) => this.actorUnit = actorUnit;
        public void SetTargetUnit(UnitController targetUnit) => this.targetUnit = targetUnit;
    }
}