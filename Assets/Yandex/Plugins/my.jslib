mergeInto(LibraryManager.library, {

    initPlayer: function () {
        return ysdk.getPlayer({ scopes: false }).then(_player => {
                player = _player;

                return player;
            });
    },
    SaveExtern: function(date){
        try {
            var dateString = UTF8ToString(date);
            var myobj = JSON.parse(dateString);
            console.log("Сохраняю файл");
            console.log(myobj);
            player.setData(myobj);
        } catch (error) {
            
        }
        
    },
    LoadExtern: function(){
        YaGames.init().then(ysdk => {
            try{
                player.getData()
                .then(_date => {
                    if (_date !== undefined){                
                        const myJSON = JSON.stringify(_date);
                        console.log("Загружаю файлы");
                        console.log(myJSON);
                        myGameInstance.SendMessage('Progress', "SetPlayerInfo", myJSON);
                    }
                    else{
                        myGameInstance.SendMessage('Progress', "SetPlayerInfo", "");
                    }                
                })
                .catch(_date => {                               
                    myGameInstance.SendMessage('Progress', "SetPlayerInfo", "");                                
                });
            }
            catch{
                _date => {                               
                    myGameInstance.SendMessage('Progress', "SetPlayerInfo", "");                                
                }
            }
        })            
    },
    ShowAdv: function(){
        ysdk.adv.showFullscreenAdv({
            callbacks: {
                onClose: function(wasShown) {
                    myGameInstance.SendMessage('Progress', "OnMusic");
                },
                onError: function(error) {
                  // some action on error
                }
            }
        })
        
    },
    ShowAdvReward: function(){
        ysdk.adv.showRewardedVideo({
            callbacks: {
                onOpen: () => {
                  console.log('Video ad open.');
                },
                onRewarded: () => {
                  console.log('Rewarded!');
                },
                onClose: () => {
                  console.log('Video ad closed.');
                  myGameInstance.SendMessage('Progress', "OnMusic");
                }, 
                onError: (e) => {
                  console.log('Error while open video ad:', e);
                }
            }
        })
        
        
    },
    Checklang: function(){
        var lang = ysdk.environment.i18n.lang;
        var buffer = _malloc(lengthBytesUTF8(lang) + 1);
        writeStringToMemory(lang, buffer);
        return buffer;        
    },
});