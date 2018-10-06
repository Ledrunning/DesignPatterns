using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class VisualStudioFacade
    {
        private TextEditor _textEditor;
        private Compiler _compiler;
        private CLR _clr;

        public VisualStudioFacade(TextEditor txEditor, Compiler compiler, CLR clr)
        {
            _textEditor = txEditor;
            _compiler = compiler;
            _clr = clr;
        }

        public void Start()
        {
            _textEditor.CreateCode();
            _textEditor.Save();
            _compiler.Compile();
            _clr.Execute();
        }

        public void Stop()
        {
            _clr.Finish();
        }
    }
}
