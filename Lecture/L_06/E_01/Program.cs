// текст-экран
string caption = "текст лвыалывалвлао";
int screenWidthPosition = (Console.WindowWidth - caption.Length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

DrawText(caption, screenWidthPosition, screenHeightPosition);//DrawText не существует-  ?

DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);
