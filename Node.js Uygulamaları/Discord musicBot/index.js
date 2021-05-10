const Discord = require("discord.js");
const { connected } = require("process");
const { connect } = require("tls");
const { measureMemory } = require("vm");

const client = new Discord.Client();

const ytdl = require("ytdl-core")
const search = require("youtube-search");
var fs = require('fs');

const opts =(search.YoutubeSearchOptions) = {
    maxResults: 3,
    key: "AIzaSyDt3Yk1z-fmXMXzVxwaYD9523YbS2QVIT8"
}

var userData = JSON.parse(fs.readFileSync("depo/puan.json",'utf8'));

const servers={

}
let server = undefined;
const list = [];

const play = async(connection,message)=>{
    const server = servers[message.guild.id];
    const stream = ytdl(server.queue[0],{
        filter:"audioonly",
        quality:"highestaudio"
    })
    server.dispatcher = connection.play(stream);
    let song=await (await ytdl.getInfo(server.queue[0])).videoDetails.title;
    server.dispatcher.on("finish",()=>{
        server.queue.shift();
        if(server.queue[0]){
            play(connection,message)
        }
        else connection.disconnect();
    })
    server.dispatcher.setVolume(5/100)
}


// client.on("voiceStateUpdate", function(oldMember, newMember){
//     channel = client.channels.cache.get('691703305633660981');
//     channel.send("Evente Hoşgeldin " + userData[oldMember.id].isim);
    
// });

client.on("message",message=>{
    console.log("gelen mesaj: "+message.content)
    var sender = message.author;

    const parsedMessage=message.content.split(" ") //!oynat URL
    const parsedMessage1 = message.content.split("-")
    switch (parsedMessage[0].toUpperCase()) {
        case "SA":
            message.channel.send("Aleyküm selam bremin")
            break;
        case "N":
            if(!parsedMessage[1]){
                message.channel.send("Seçim yapmadın")
                return;
                }
            if(parsedMessage[1] > 3 || parsedMessage[1] < 0 ){
                message.channel.send("0-3 arası giriniz.")
                return;
                }
            if(isNaN(parsedMessage[1])){
                message.channel.send("Sayi giriniz")
                return
            }
            if(!message.member.voice.channel){
                message.channel.send("Ses kanalı olmalıdır!")
                    return;
                }
            if(!servers[message.guild.id])
                servers[message.guild.id]={
                    queue:[]
                }
            server=servers[message.guild.id]
            server.queue.push(list[parsedMessage[1]-1])
            list.splice(0,list.length)
            if(server.queue.length<=1)
            try{
                message.member.voice.channel.join().then(connection=>{
                    play(connection,message)
                })
            }catch(e){
                console.log("hata oluştu"+e)
            }
            break;
        case "!OYNAT":
            if(!parsedMessage[1]){
            message.channel.send("Link girmelisiniz!")
            return;
            }
            if(!message.member.voice.channel){
            message.channel.send("Ses kanalı olmalıdır!")
                return;
            }
            if(!servers[message.guild.id])
            servers[message.guild.id]={
                queue:[]
            }
            server=servers[message.guild.id]
            server.queue.push(parsedMessage[1])
            if(server.queue.length<=1)
            try{
                message.member.voice.channel.join().then(connection=>{
                    play(connection,message)
                })
            }catch(e){
                console.log("hata oluştu"+e)
            }
            break;
        case "!GEC":
            if(server.dispatcher)server.dispatcher.end();
            break;
        case "!ÇIK":
            if(message.guild.voice.channel){
                server.dispatcher.end()
                console.log("kuyruk durduruldu")
            }
            if(message.guild.connection)
            message.guild.voice.connection.disconnect();
            break;
        case "!SES":
            if(!parsedMessage[1] || isNaN(parsedMessage[1])){
                message.channel.send("Sayi girmelisiniz!")
                return;
                }
            server.dispatcher.setVolume(parsedMessage[1]/100)
            message.channel.send("Ses ayarlandı")
            break;
        case "!PUAN":
                message.channel.send("Puanınız = " + userData[sender.id].puan)
            break;
        case "!LEVEL":
                message.channel.send("```yaml\nLeveliniz: " + Math.floor((userData[sender.id].puan+1000)/1000)+"\n```")
            break;
        case "!DUR":
            server.dispatcher.pause();
            message.channel.send("Müzik durduruldu")
            break;
        case "!DEVAM":
            server.dispatcher.resume();
            message.channel.send("Müzik başlatıldı")
            break;
        case "!ARA":
            for(var i = 2;i<parsedMessage.length;i++){
                parsedMessage[1] = parsedMessage[1] + parsedMessage[i];
            }
            if(!parsedMessage[1]){
                message.channel.send("Aranacak yazı girmelisiniz!")
                return;
                }
            search(parsedMessage[1],opts,(err,result)=>{
                if(err) return console.log(err)
                return result.filter(item=>item.kind==="youtube#video").map((item,index)=>{
                    message.channel.send("No : "+(index+1)+", " + item.title)
                    list.push(item.link);
                })
            })
            break;
        default:
            break;
    }
    switch (parsedMessage1[0].toUpperCase()) {
        case "!Y":
            channel = client.channels.cache.get('691703305633660981');
            channel.send(parsedMessage1[1]);
            break;
            case "!ARAT":
                if(!parsedMessage1[1]){
                    message.channel.send("Aranacak yazı girmelisiniz!")
                    return;
                    }
                search(parsedMessage1[1],opts,(err,result)=>{
                    if(err) return console.log(err)
                    return result.filter(item=>item.kind==="youtube#video").map((item,index)=>{
                        message.channel.send("No : "+(index+1)+", " + item.title)
                        list.push(item.link);
                    })
                })
                break;
        default:
        break;
    }


    if(!userData[sender.id]) userData[sender.id] = {
        puan: 0,
        isim: sender.username
    }

    fs.writeFile('depo/puan.json' , JSON.stringify(userData), (err) =>{
        if(err) console.log(err);
    });
})



client.login("Nzg3NjY0MTk5MjI0MzkzNzQ4.X9YPcw.bSxTNS91USPSmw0QtkYeiyW2DQg");