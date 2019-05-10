using Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Computer<T> : IComputer<T>
    {
        public IProcessor<T> _cpu { get; set; }
        public IMotherboard<T> _board { get; set; }
        public IPrimaryMemory<T> _ram { get; set; }
        public ISecondaryMemory<T> _harddrive { get; set; }

        public Computer(
             IProcessor<T> Cpu,
             IMotherboard<T> Board,
             IPrimaryMemory<T> Ram,
             ISecondaryMemory<T> Harddrive
            )
        {
            _cpu = Cpu;
            _board = Board;
            _ram = Ram;
            _harddrive = Harddrive;
        }

        public void FunctionCallExample()
        {

        }
    }
}
