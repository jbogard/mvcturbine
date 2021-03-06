﻿namespace MvcTurbine.Samples.FilterInjection.Services {
    public interface IMessageService {
        string GetWelcomeMessage();
        string GetFilterMessage();
        string ReplayMessage(string message);
    }
}