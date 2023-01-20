|               |               |               |               |               |               |
|:-------------:|:-------------:|:-------------:|-------------:|-------------:|-------------:|
| ![Hack the planet](https://img.shields.io/badge/Hack-The%20Planet-orange) | [![Discord](https://img.shields.io/discord/667340023829626920?logo=discord)](https://discord.gg/ahVq54p) | [![Twitter](https://img.shields.io/twitter/follow/4xsample?style=social&logo=twitter)](https://twitter.com/4xsample/follow?screen_name=shields_io) | [![4Xsample@mastodon.social](https://img.shields.io/badge/Mastodon-@4Xsample-blueviolet?style=for-the-badge&logo=mastodon)](https://mastodon.social/@4Xsample) | [![4Xsample](https://img.shields.io/badge/Twitch-4Xsample-6441A4?style=for-the-badge&logo=twitch)](https://twitch.tv/4Xsample) | [![PayPal](https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white)](https://www.paypal.com/donate/?hosted_button_id=EFVMSRHVBNJP4) |

# Creació de votacions Twitch

Aquest codi és una classe C# per crear votacions en un canal de Twitch. La votació es composa d'una pregunta i una sèrie d'opcions que es poden modificar segons les necessitats. A més, es pot establir la durada de la votació, així com l'opció de votar amb bits o punts de canal.

## Personalització de la votació

Per personalitzar la votació, es pot modificar les següents variables:

- `pollQuestion`: Aquesta variable conté la pregunta de la votació. Es pot modificar reemplaçant el text "Pregunta" entre les cometes simples per la pregunta desitjada.

- `pollOptions`: Aquesta variable conté les opcions de votació. Es pot modificar afegint o eliminant opcions i reemplaçant el text entre les cometes simples per les opcions desitjades. El codi permet fins a 5 opcions.

- `duration`: Aquesta variable conté la durada de la votació en segons. Es pot modificar reemplaçant el valor numèric per la durada desitjada

- `bitsPerVote`: Aquesta variable conté el nombre de bits necessaris per fer un vot. Es pot deixar a 0 si no es vol habilitar aquesta opció o posar un valor numèric per habilitar-la.

- `channelPointsPerVote`: Aquesta variable conté el nombre de punts de canal necessaris per fer un vot. Es pot deixar a 0 si no es vol habilitar aquesta opció o posar un valor numèric per habilitar-la.

## Utilització

Per utilitzar aquest codi, s'ha de reemplaçar la pregunta de la votació i les opcions de votació amb les pròpies. A més, es pot modificar la durada de la votació, així com habilitar o deshabilitar l'opció de votar amb bits o punts de canal.

Per executar la votació, es pot cridar el mètode `CPH.TwitchPollCreate(pollQuestion, pollOptions, duration, bitsPerVote, channelPointsPerVote)` passant com a paràmetres les variables corresponents.

## Disclaimer: 
*Aquest codi s'ofereix tal com és i no es garanteix que funcioni correctament en totes les condicions. No em faig responsable dels danys que puguin resultar de l'ús d'aquesta informació. Utilitzeu-lo sota la vostra pròpia responsabilitat. Si teniu dubtes pregunteu i respondré al que pugui. Si voleu obrir proposar cambis podeu obrir fork i i voleu seguir-me, al panel del principi d'aquest readme podeu trobar links a les meves xarxes socials, Twitch i PayPal per si també voleu donar suport al meu treball.*