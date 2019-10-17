﻿namespace NutritionalTracker.Commands {
    public interface ICommandHandler<TCommand> {
        void Handle(TCommand command);
    }
}
