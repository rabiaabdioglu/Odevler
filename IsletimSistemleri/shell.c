


#include <stdio.h>
#include <sys/wait.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>



#define	CMD_MAX	80
#define	ARG_MAX	10

char komut[CMD_MAX];			
char *argv[ARG_MAX];		
int pid;
int i;
char *buf;
char pid_history[100];


/////////////////////////////FONKSIYONLAR

void cmd_al(){
           //kullanıcı girdisi al
	       fgets(komut, CMD_MAX, stdin);
           if ((strlen(komut) > 0) && (komut[strlen(komut) - 1] == '\n'))
             komut[strlen (komut) - 1] = '\0';


}

void cmd_parse(){

            // komut dizisini parçalara ayırır.
            //ayrılan parçalar max 10 adet olup argv dizisine atılacaktır
           // bzero(komut,80);


	        char *cmd_gecici;
	        int i = 0;
	        cmd_gecici = strtok(komut," ");
	       
           while(cmd_gecici != NULL){
                //argv dizisine parca parca atar

                argv[i] = cmd_gecici;
                i++;
                cmd_gecici = strtok(NULL," ");
            }}

void pwd(){ 
            buf=(char*)malloc(100*sizeof(char));
            getcwd(buf,100);
}
/////////////////////////////BUILTIN KOMUTLAR

void cd_path(){
        if(argv[1]==NULL){
            //gidilecek dosya adı yoksa bir önceki dosyaya döner
             chdir("..");}

        else{
            //birden çok parametre girildiyse hata verir.
            //Değilse istenilen dosya yoluna gidilir.
            if(argv[2]!=NULL){printf("Çok fazla parametre girildi.");}
            else if((chdir(argv[1]))==0){//printf("Dosya yolu değiştirildi.");
}} }

void show_pid(){  printf("%s",pid_history);}

void built_exit(){    
         // "exit" komutu
         if(!strcmp("exit",komut)){
             printf("\nexit\n");
             kill(pid,SIGKILL);
             exit(0);}
}

void bilgi(){
printf("\nGRUP-3\n______________________________________________\nG191210089\tMehmet Yalçın\nB201210302\tRabia Abdioğlu\nG171210302\tHüseyin Öztürk\nG201210301\tNagihan Yalçın\nB191210386\tEnes Kayri\n");}

void help(){
printf("\nBuilt-in komutlar\n-> cd\n-> showpid\n-> exit\n-> bilgi\n-> help\n");}

int main(){
        
      
        //ekran temizlemek için
        const char* CLEAR_SCREEN_ANSI="\e[1;1H\e[2J";
        write(STDOUT_FILENO,CLEAR_SCREEN_ANSI,12);

        //exit yazılana kadar sonsuz döngü
        int k =1;
        int status;
            
           help();
            while(1){ 

               
        /*    memset fonksiyonu ile showpid beraber çalışmıyor. 
              ikisi ayrı şekilde çalışıyor.   

                memset(komut,'\0',sizeof(char*)*CMD_MAX);
                memset(argv,'\0',sizeof(char*)*ARG_MAX);
           */

                pwd();  
                //varsayılan prompt
                 printf("\n\e[0;33m%s:sau >\e[0;37m ",buf); 
                //komut alınır 
                cmd_al();   
                //alınan komut uygun hale getirilir ve komut parçalarına ayrılır
           
                if(!strcmp("",komut)) continue;
                cmd_parse();
                    // boş komutları geç
                    
                if(!strcmp(komut,"cd"))cd_path();
                if(!strcmp(komut,"exit"))built_exit();
                if(!strcmp(komut,"showpid"))show_pid();
                if(!strcmp(komut,"bilgi"))bilgi();
                if(!strcmp(komut,"help"))help();


                pid = fork();

                if(pid==-1){  printf("HATA : Komut icra edilemiyor.");  return 0;  }      
                

                else if(pid==0){
               // komut çalıştır
                    status=execvp(argv[0], argv);

                    char *donusum;
                    sprintf(donusum,"%d",getpid());
                    strcat(pid_history,donusum);
                    strcat(pid_history,"\n");   }		

                else{//ebeveyn yavruyu bekler
                    do{waitpid(pid,&status,0);                              
                      }while(!WIFEXITED(status)&& !WIFSIGNALED(status)); }}   

return 0;

}

