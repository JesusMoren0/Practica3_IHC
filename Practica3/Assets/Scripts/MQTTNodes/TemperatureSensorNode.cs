using UnityEngine;

public class TemperatureSensorNode : BaseNode
{
    public string temperatureTopic = "casa/sala/sensor1";

    public float temperature = 20f;

    public float publishRate = 10f;

    private float publishTimer = 0;

    protected override void Start()
    {
        base.Start();
        //Iniciarlizar sensor
        PublishMessage(temperatureTopic, temperature.ToString());
    }

   protected private void PublishMessage(string topic, string message) 
   {
       base.PublishMessage(topic, message);
       //Algo mas despues de mandar el mensaje
   }

    // Update is called once per frame
    void Update()
    {
        if((publishTimer += Time.deltaTime) >= publishRate)
        {
            temperature += 1f;
            PublishMessage(temperatureTopic, temperature.ToString());
            publishTimer = 0;
        }
    }
}
