const passwordText = "Пароль может содержать буквы английского алфавита и цифры от 0 до 9. Минимальная длина пароля 8 символов, максимальная 16";
function checkPassword1(){
    const arr_symbols = ['0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'];
    let password = $('#passwordInput1').val();
    if(password.length>0){
        if(password.length>=8 && password.length<=16){
            let flag = false;
            for(i=0;i<password.length;i++){
                for(j=0;j<arr_symbols.length;j++){
                    if(password[i]==arr_symbols[j]){
                        flag = true;
                    } 
                }
                if(flag == false){
                    $("#passwordHelp1").empty().append("Пароль не удовлетворяет условиям");
                    document.getElementById('passwordHelp1').style.setProperty('color','red','important');
                        return false;
                }
                else{
                    $("#passwordHelp1").empty().append("Пароль подходит");
                    document.getElementById('passwordHelp1').style.setProperty('color','#008000','important');
                }
            }
        }
        else {
            $("#passwordHelp1").empty().append("Пароль не удовлетворяет условиям");
            document.getElementById('passwordHelp1').style.setProperty('color','red','important');
            return false;
        }
    }
    else {
        $("#passwordHelp1").empty().append(passwordText);
        document.getElementById('passwordHelp1').style.setProperty('color','grey','');
        return false;
    }
  
};
        