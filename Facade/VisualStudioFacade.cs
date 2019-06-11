namespace Facade
{
    public class VisualStudioFacade
    {
        private readonly CLR _clr;
        private readonly Compiler _compiler;
        private readonly TextEditor _textEditor;

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