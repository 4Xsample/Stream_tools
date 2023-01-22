|               |               |               |               |               |               |
|:-------------:|:-------------:|:-------------:|-------------:|-------------:|-------------:|
| ![Hack the planet](https://img.shields.io/badge/Hack-The%20Planet-orange) | [![Discord](https://img.shields.io/discord/667340023829626920?logo=discord)](https://discord.gg/ahVq54p) | [![Twitter](https://img.shields.io/twitter/follow/4xsample?style=social&logo=twitter)](https://twitter.com/4xsample/follow?screen_name=shields_io) | [![4Xsample@mastodon.social](https://img.shields.io/badge/Mastodon-@4Xsample-blueviolet?style=for-the-badge&logo=mastodon)](https://mastodon.social/@4Xsample) | [![4Xsample](https://img.shields.io/badge/Twitch-4Xsample-6441A4?style=for-the-badge&logo=twitch)](https://twitch.tv/4Xsample) | [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://www.paypal.com/donate/?hosted_button_id=EFVMSRHVBNJP4) |

# CPHInline - Creació de clips i publicació en Discord
Aquest codi és una acció per al programa d'automatismes per streamers [Streamer.bot](Streamer.bot). Aquesta acció permet als usuaris fer clips dels streams i publicar-los automàticament al canal de Twitch i al canal de Discord especificat.

## Funcionament
La classe consta d'un mètode Execute() que s'executa quan es crida la classe. El mètode:

1. Comprova si la transmissió en directe està en línia
2. Crea el clip de la transmissió
3. Publica el clip en el canal de xat de Twitch
4. Publica el clip en el canal de Discord utilitzant un webhook

## Configuració

Per configurar aquesta acció, haureu de crear una acció al programa Streamer.bot escollir executar codi i enganxar aquest codi sencer. A més, també és necessari assegurar-se que les llibreries System, System.Net.Http i Newtonsoft.Json estiguin incloses a les referencies del projecte. Obviament despres cal crear algun/s detonant/s per aquesta acció (Comandes de text, recompensa amb punts de canal, botó per [l'Stream Deck](https://amzn.to/3XoRUT2) o un botó pels Decks de la web [Streamer.bot](Streamer.bot))


## Personalització

Per personalitzar aquesta acció, haureu de canviar la variable `discordWebhook` per la URL del webhook del vostre canal de Discord. També podeu canviar el missatge que s'envia al canal de Twitch i al canal de Discord per adaptar-lo a les vostres necessitats.

## Disclaimer: 
*Aquest codi s'ofereix tal com és i no es garanteix que funcioni correctament en totes les condicions. No em faig responsable dels danys que puguin resultar de l'ús d'aquesta informació. Utilitzeu-lo sota la vostra pròpia responsabilitat. Si teniu dubtes pregunteu i respondré al que pugui. Si voleu obrir proposar cambis podeu obrir fork i i voleu seguir-me, al panel del principi d'aquest readme podeu trobar links a les meves xarxes socials, Twitch i PayPal per si també voleu donar suport al meu treball.*