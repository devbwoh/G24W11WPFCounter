using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace G24W11WPFCounter;

public class CounterViewModel : INotifyPropertyChanged {
    private CounterModel _model;
    public event PropertyChangedEventHandler? PropertyChanged;

    public CounterViewModel() {
        _model = new CounterModel();
    }

    public int Value {
        get => _model.Count;
        set {
            _model.Count = value;
            OnPropertyChanged();
        }
    }

    // CallerMemberName 애트리뷰트는 호출한 함수 이름
    // 프로퍼티 이름인 "Value"를 argument로 넘겨줌
    protected void OnPropertyChanged([CallerMemberName] string propName = "") {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
