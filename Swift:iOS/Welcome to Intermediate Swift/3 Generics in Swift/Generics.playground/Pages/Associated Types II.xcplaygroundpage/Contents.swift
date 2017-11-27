// Associated Type II
// imagine we have diff kinds of data and diff ways to display
// we can write diff stuff for each type, but we want to write some standard stuff

protocol DataProvider {
    // this will act as a data provider for different views.
    // assume it comes in diff ways. just care about how it asks for it.
    associatedtype Object
    
    func object(atIndex index: Int) -> Object
}

// let's guarantee that a view has some data and the view will config itself
// regardless the view, we'llcall and pass on the data

protocol ConfigurableView {
    // these will have a standard interface to accept some data.
    associatedtype Data
    
    func configure(with data: Data)
}

class ViewController<View: ConfigurableView, DataSource: DataProvider> where View.Data == DataSource.Object {
    let view: View
    let data: DataSource
    
    init(view: View, data: DataSource) {
        self.view = view
        self.data = data
    }
    
    func start() {
        // tog et an instance of data for view
        let object = data.object(atIndex: 0)
        view.configure(with: object) // this didn't work until we added the where clause earlier
        
    }
}

// pasted in some code
struct StringDataProvider: DataProvider {
    
    let data = ["someValue", "anotherValue"]
    
    func object(atIndex index: Int) -> String {
        return data[index]
    }
}

struct IntView: ConfigurableView {
    
    func configure(with data: Int) {
        //
    }
}

struct StringView: ConfigurableView {
    func configure(with data: String) {
        //
    }
}

//let controller = ViewController(view: IntView(), data: StringDataProvider())
// this doesn't work because stuff doesn't match!

let controller = ViewController(view: StringView(), data: StringDataProvider())
// this works!

// Extending GENERIC TYPES
import Foundation

struct Weather {
    let temperature: Double
    let humidity: Double
    let chanceOfRain: Double
    let icon: String
    let highTemperature: Double
    let lowTemperature: Double
    let sunrise: Date
    let sunset: Date
}

let current = Weather(temperature: 63, humidity: 0.36, chanceOfRain: 0.04, icon: "Cloudy", highTemperature: 67, lowTemperature: 50, sunrise: Date(), sunset: Date())

protocol PrettyPrintable {
    var prettyDescription: String { get }
}

extension Weather: PrettyPrintable {
    var prettyDescription: String {
        return "Temperature: \(temperature)\nHumidity: \(humidity)\nChance of Rain: \(chanceOfRain)\nIcon: \(icon)\nHigh Temperature: \(highTemperature)\nLow Temperature: \(lowTemperature)\nSunrise Time: \(sunrise)\nSunset Time: \(sunset)"
    }
}

let tuesday = Weather(temperature: 63, humidity: 0.36, chanceOfRain: 0.04, icon: "Cloudy", highTemperature: 67, lowTemperature: 50, sunrise: Date(), sunset: Date())

let wednesday = Weather(temperature: 63, humidity: 0.36, chanceOfRain: 0.04, icon: "Cloudy", highTemperature: 67, lowTemperature: 50, sunrise: Date(), sunset: Date())

let thursday = Weather(temperature: 63, humidity: 0.36, chanceOfRain: 0.04, icon: "Cloudy", highTemperature: 67, lowTemperature: 50, sunrise: Date(), sunset: Date())

let week = [current, tuesday, wednesday, thursday]

//extension Array where Element: PrettyPrintable {
//    var prettyDescription: String {
//        var output = ""
//        
//        for (index, element) in self.enumerated() {
//            output += "\n\n*******\n\nIndex: \(index)\n\n\(element.prettyDescription)"
//        }
//        
//        return output
//    }
//}

extension Sequence where Iterator.Element == Weather {
    var prettyDescription: String {
        var output = ""
        
        for (index, element) in self.enumerated() {
            output += "\n\n*******\n\nIndex: \(index)\n\n\(element.prettyDescription)"
        }
        
        return output
    }
}

print(week.prettyDescription)

// new func? returns well formatted console log
dump(current) //looks good
