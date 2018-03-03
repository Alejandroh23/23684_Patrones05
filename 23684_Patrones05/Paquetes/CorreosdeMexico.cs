using System;
namespace _Patrones05.Paquetes
{
    public class CORREOSDEMEXICO:Observable, Updatable {
    private ArrayList<Observer> observers;

    private String address;
    private long updateInterval = 1200;

        public CORREOSDEMEXICO()
    {
        observers = new ArrayList<>();
    }

    private void checkpointChanged()
    {
        CorreosDeMexicoDataWrapper data = new CorreosDeMexicoDataWrapper(this.address);
        for (Observer observer: observers)
        {
            observer.update(data);
        }
    }

    public void setCheckpoint(String address)
    {
        this.address = address;
        this.checkpointChanged();
    }

    @Override
    public void add(Observer observer)
    {
        this.observers.add(observer);
    }

    @Override
    public void remove(Observer observer)
    {
        this.observers.remove(observer);
    }

    @Override
    public void notifyObservers()
    {
        CorreosDeMexicoDataWrapper data = new CorreosDeMexicoDataWrapper(this.address);
        for (Observer observer: this.observers)
        {
            observer.update(data);
        }
    }

    @Override
    public void updatePackageInfo()
    {
        Timer timer = new Timer();
        UUID uuid = UUID.randomUUID();
        String randomUUIDString = uuid.toString();
        timer.schedule(new TimerTask() {
            @Override
            public void run()
        {
            setCheckpoint(randomUUIDString);
        }
    }, 0, this.updateInterval);
    }
}