
var args = WScript.Arguments;
var shell = new ActiveXObject("WScript.Shell");

if( args.length < 1 ) {
	WScript.Echo("postBehavior.js  <�Ώۃt�@�C��> ");
	WScript.Quit(1);
}

// �t�@�C�������R�}���h���C������擾
var targetFile = args(0);

//  �t�@�C���֘A�̑����񋟂���I�u�W�F�N�g���擾
var fs = new ActiveXObject( "ADODB.Stream" );
fs.Type = 2;
fs.Charset = "UTF-8" ;

//  �t�@�C����ǂݎ���p�ŊJ��
fs.Open();
fs.LoadFromFile(targetFile);


//var file = fs.OpenTextFile( targetfile, 1, true, -1 );

while ( !fs.EOS ) {

  // �����o���t�@�C���̎w�� (�V�K�쐬����)
  var output = new ActiveXObject("ADODB.Stream");
  output.Type = 2;
  output.Charset = "UTF-8";
  output.Open();

  // �t�@�C�������s�ǂݍ��� -1�F�S�s�ǂݍ��݁E-2�F��s�ǂݍ���
  var lineStr = fs.ReadText(-2);    
  var flds = lineStr.split('\t');   // 

  //  0�F������̂ݏ������݁E1�F������ + ���s����������
  output.WriteText(flds[1], 1);    

  // �����o���t�@�C���̕ۑ�
  //  1�F�w��t�@�C�����Ȃ���ΐV�K�쐬�E2�F�t�@�C��������ꍇ�͏㏑��
  var outfile = "json.txt" ;
  output.SaveToFile(outfile, 2);
  output.Close();

  var cmd = "curl -H \"Content-type: application/json\" -XPUT \"http://localhost:9200/simba-ea-master/behaviorChunk/"+ flds[0] +"\" -d @json.txt" ;
  WScript.Echo ("command: " + cmd);
  var e = shell.Exec(cmd); // �R�}���h�����s
  while (e.Status == 0) {
    WScript.Sleep(100);
  }
  
}

//  �t�@�C�������
fs.Close();

//  �I�u�W�F�N�g�����
fs = null;

WScript.Echo( "�I��" );



