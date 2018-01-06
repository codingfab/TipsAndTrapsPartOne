using System.ComponentModel;
using System.Runtime.CompilerServices;
using TipsAndTrapsPartOne.Annotations;

namespace TipsAndTrapsPartOne._05_CallerInfoAttributes
{
    public class CallerInfoAttributeDemo
    {
        public string WhoCalledMe([CallerMemberName] string callingMember = null)
        {
            return "I was called from member " + callingMember;
        }

        public string WhatFileCalledMe([CallerFilePath] string callingFile = null)
        {
            return "I was called by file " + callingFile;
        }

        public string WhatLineCalledMe([CallerLineNumber] int callingLineNum = 0)
        {
            return "I was called from line " + callingLineNum;
        }
    }

    public class CallerInfoAttributeDemo2 : INotifyPropertyChanged
    {
        private int _age;
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                _age = value;
                // Without [CallerMemberName] we have to pass a string of the prop name
                // OnPropertyChanged("Age");
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}