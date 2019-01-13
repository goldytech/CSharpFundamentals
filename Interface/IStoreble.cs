using System;

namespace Interface
{
    public interface IStoreable
    {
        void Write(object obj);
        string Read();
        ReturnStatus Status { get; set; }
    }

    public enum ReturnStatus
    {
        Ok,
        Fail
    };
}