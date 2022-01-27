

##C++

> Basic Shell in Linux


![alt text](https://github.com/rabiaabdioglu/Odevler/blob/main/Otopark_IOT/Resim2.jpg)







>KODLAR


```

#include <stdio.h>
#include <sys/wait.h>
#include <unistd.h>
#include <stdlib.h>
#include <string.h>



#define	CMD_MAX	80
#define	ARG_MAX	10

char komut[CMD_MAX];			
char *argv[ARG_MAX];			
pid_t pid;
int i;
char *buf;
char *pid_history;
int  pid_say=0;


/////////////////////////////FONKSIYONLAR

void cmd_al(){

         
             //kullanÄ±cÄ± girdisi al
	        fgets(komut, CMD_MAX, stdin);

            
	        if ((strlen(komut) > 0) && (komut[strlen(komut) - 1] == '\n'))
            komut[strlen (komut) - 1] = '\0';


}

void cmd_parse(){

            // komut dizisini parÃ§alara ayÄ±rÄ±r.
            //ayrÄ±lan parÃ§alar max 10 adet olup argv dizisine atÄ±lacaktÄ±r
           // bzero(komut,80);


	        char *cmd_gecici;
	        int i = 0;
	        cmd_gecici = strtok(komut," ");
	       
           while(cmd_gecici != NULL){
                //argv dizisine parca parca atar

	            argv[i] = cmd_gecici;
	            i++;
	            cmd_gecici = strtok(NULL, " ");
	        }


}
void pwd(){ 
            buf=(char*)malloc(100*sizeof(char));
            getcwd(buf,100);
}
/////////////////////////////BUILTIN KOMUTLAR

void cd_path(){
        if(argv[1]==NULL){unsetenv(buf);}
        else{ setenv("",buf,0);}
         
        
} 

void show_pid(){
        int j=0;
        for(j=0;j<strlen(pid_history);j++){
        printf("%s",pid_history);
        printf("\n");}
}

void built_exit(){    
         // "exit" komutu
         if(!strcmp("exit",komut)){
             printf("\nexit\n");
             kill(pid,SIGKILL);
             exit(0);}
}


int main(){

        //ekran temizlemek iÃ§in
        const char* CLEAR_SCREEN_ANSI="\e[1;1H\e[2J";
        write(STDOUT_FILENO,CLEAR_SCREEN_ANSI,12);

        //exit yazÄ±lana kadar sonsuz dÃ¶ngÃ¼
        int k =1;
        int status;
            while(1){
                pwd();  //varsayÄ±lan prompt
                 printf("\n\n\e[0;33m%s: rabia >\e[0;37m ",buf); 
                //komut alÄ±nÄ±r 
                cmd_al();   
                //alÄ±nan komut uygun hale getirilir ve komut parÃ§alarÄ±na ayrÄ±lÄ±r
           
                    if(!strcmp("",komut)) continue;
                cmd_parse();
                    // boÅŸ komutlarÄ± geÃ§
                        
                    if(!strcmp(argv[0],"cd"))cd_path();
                    if(!strcmp(argv[0],"exit"))built_exit();
                    if(!strcmp(argv[0],"showpid"))show_pid();

	                pid = fork();

                  // if(pid>0){printf("\n \nFork baÅŸarÄ±lÄ±  ebeveyn pid : %d\n",pid);    }

                    if(pid<0){
                    //printf("\n \nFork baÅŸarÄ±sÄ±z : %d\n",pid);
                        return 1;}
                    else if(pid==0){
                   // komut Ã§alÄ±ÅŸtÄ±r

		            status=execvp(argv[0], argv);
                    
                        if(status==-1){printf("HATA : Komut icra edilemiyor. %d",getpid()); 

                            return 0; }
                            
                    }		

                    else{//ebeveyn yavruyu bekler
                       do{   waitpid(pid,&status,0);
                                  pid_history+=getpid();
                                   pid_history="\n";
                          }while(!WIFEXITED(status)&& !WIFSIGNALED(status)); }
}   

return 0;
}

```
