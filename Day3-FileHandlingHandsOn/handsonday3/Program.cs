using System;
using System.IO;

namespace handsonday3
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileCreation fileCreate = new FileCreation();
            //fileCreate.create();

            //FileDeletion fileDelete = new FileDeletion();
            //fileDelete.delete();

            //FileAlreadyCreated fileAlreadyCreated = new FileAlreadyCreated();
            //fileAlreadyCreated.exist();

            WritingFile writingFile = new WritingFile();
            //writingFile.WriteFile();
            //writingFile.ReadFile();
            //writingFile.ParticularLine();
            writingFile.LineCount();
        }
    }
}
