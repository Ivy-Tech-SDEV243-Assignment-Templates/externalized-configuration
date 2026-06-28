/*
This program doesn't accept user input. Everything comes from the configuration
file. It always builds a pipeline with the three transforms in the provided
order. The main focus of the solution is how everything is rigged together: the
CLI application represents a client using the library.

The idea is that the consumer instantiates the pipeline with immutable
configuration for the transforms, then runs a series of documents through the
pipeline. In reality, we will probably only run one document through the
pipeline.
*/

// Constants
const string textFilePath = "samples/input.txt";
const string emojiMapPath = "samples/emoji-map.txt";
const string outputFilePath = "samples/output.txt";
var caseOption = CaseOption.Lower;

string input = File.ReadAllText(textFilePath);
Dictionary<string, string> emojiMap = EmojiFileParser.Parse(emojiMapPath);

var caseTransform = new CaseTransform(caseOption);
var emojiTransform = new EmojiTransform(emojiMap);
var whitespaceTransform = new WhitespaceTransform(spacesAfterSentenceEnd: 2);

// Transform first file
string output = caseTransform.Transform(input);
output = emojiTransform.Transform(output);
output = whitespaceTransform.Transform(output);
File.WriteAllText(outputFilePath, output);
