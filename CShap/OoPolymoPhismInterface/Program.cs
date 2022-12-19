using OoPolymoPhismInterface;

//FileOne f = new();
//f.WriteTextFile();
//f.WriteBinaryFile();
//f.ReadFile();
//((IBinaryFile)f).ShowInfo();
//(f as IBinaryFile).ShowInfo();

//FileTow f = new();
//f.WriteTextFile();
//f.WriteBinaryFile();
//(f as IBinaryFile).ReadFile();
//(f as ITextFile).ReadFile();

ITextFile itext = new FileOne();
itext.ReadFile();
itext = new FileTow();
itext.ReadFile();

