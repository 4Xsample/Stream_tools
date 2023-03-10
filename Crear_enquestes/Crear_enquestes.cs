using System; 
using System.Collections.Generic;

public class CPHInline
{
    public bool Execute()
    {
        // Reemplaça el text entre les cometes amb la pregunta de la votació
        var pollQuestion = "Pregunta";

        // Aquestes són les opcions de votació, pot tenir fins a 5, si no es volen 5, simplement elimina les línies que no es vulguin, per exemple,
        // si es volen 2, elimina l'opció 3, 4 i 5.
        // i assegura't de renombrar les opcions modificant el text entre les cometes
        var pollOptions = new List<string>();
        pollOptions.Add("Resposta 1");
        pollOptions.Add("Resposta 2");
        pollOptions.Add("Resposta 3");
        pollOptions.Add("Resposta 4");

        // Canvia el número de sota per modificar la durada de la votació, està en segons
        var duration = 60;

        // Les properes dos són opcions, deixa-les a 0 per deshabilitar-les, o, posa un valor per habilitar-les
        var bitsPerVote = 1;
        var channelPointsPerVote = 10;

        CPH.TwitchPollCreate(pollQuestion, pollOptions, duration, bitsPerVote, channelPointsPerVote);

        return true;
    }
}