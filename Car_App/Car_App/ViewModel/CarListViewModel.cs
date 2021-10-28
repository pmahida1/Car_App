using Car_App.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Car_App.ViewModel
{
    
    public class CarListViewModel
    {
        public ObservableCollection<CarModel> CarList { get; set; }
        public CarListViewModel()
        {
            CarList = new ObservableCollection<CarModel>();
            CarList.Add(new CarModel
            {
                CarName = "Aston Martin Rapide E",
                CarColor = "Light Gray",
                DrivenKM = "12344",
                Average = "19.8L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "The famed British exotic sports-car maker Aston Martin is building a full-electric version of the gorgeous and capable Rapide coupe. It comes wrapped in aluminum and carbon fiber body panels, and packs dual rear-mounted motors that generate over 600 horsepower with 700 pound-feet of torque. That should enable a 0-60 mph time under four seconds; top speed is 155 mph. It’s expected to run for over 200 miles on a charge.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37033a95e0230008f64eb2%2F2020-Aston-Martin-Rapide-E%2F960x0.jpg%3FcropX1%3D0%26cropX2%3D3000%26cropY1%3D157%26cropY2%3D1844"
            });
            CarList.Add(new CarModel
            {
                CarName = "Chevrolet Corvette Stingray",
                CarColor = "Red",
                DrivenKM = "12341",
                Average = "17.8L",
                CarYear = "2020 ",
                FuelMode = "Diseal",
                Details = "Though there is an assortment of brand-new and fully redesigned passenger cars hitting the road for 2020 model year, their numbers are dwindling as buyers are instead choosing sport-utility vehicles as their rides of choice. Stalwart sedans like the Chevrolet Impala and Ford Taurus are being discontinued, with the number of small cars in particular thinning rapidly. While there were 26 subcompact models on the market as recently as 2016, they’re down to just 17 for 2019, with the Ford Fiesta and Chevrolet Sonic reportedly bowing out at the end of the current model year.",
                Image = "https://thumbor.forbes.com/thumbor/fit-in/1200x0/filters%3Aformat%28jpg%29/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d35eacaf1176b0008974b54%2F0x0.jpg%3FcropX1%3D790%26cropX2%3D5350%26cropY1%3D784%26cropY2%3D3349"
            });
            CarList.Add(new CarModel
            {
                CarName = "Cadillac CT4-V",
                CarColor = "Black",
                DrivenKM = "12244",
                Average = "20.8L",
                CarYear = "2020",
                FuelMode = "CNG",
                Details = "Cadillac introduces a new compact luxury sedan for 2020, the CT4. Adorned with uncluttered styling, it fills the slot in the lineup that was vacated when the ATS was discontinued. Few details on the base model are available as of this writing, but we do know it will be rear drive with all-wheel-drive available, and come powered by a turbocharged four-cylinder engine with a 10-speed automatic transmission. Cadillac has, however, released preliminary information on the sporty CT4-V model, which will feature a 2.7-liter turbocharged engine with an estimated 320 horsepower, a near perfect 50/50 front to rear weight ratio, grippy Brembo brakes, and precise handling abilities. Available features include Cadillac’s semi-autonomous Super Cruise system that allows hands-free highway driving.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37038495e0230008f64ec1%2F2020-Cadillac-CT4-V%2F960x0.jpg%3FcropX1%3D569%26cropX2%3D5130%26cropY1%3D347%26cropY2%3D2912"
            });
            CarList.Add(new CarModel
            {
                CarName = "Cadillac CT5",
                CarColor = "Red",
                DrivenKM = "12344",
                Average = "22.8L",
                CarYear = "2020",
                FuelMode = "CNG",
                Details = "The Cadillac CT5 replaces the midsize CTS for 2020, and is dynamically styled with a broad grille, narrow LED headlamps and a sleek fastback roofline. The CT5 comes powered by either a turbocharged 2.0-liter 237-horsepower four-cylinder engine or a livelier 335-horsepower twin-turbo 3.0-liter V6, each with specific exhaust-note tuning. Both drive the rear wheels via a 10-speed automatic transmission, with all-wheel drive optional. There’s also a high-performance CT5-V variant with a 355 horsepower version of the V6 and performance-minded upgrades. Most of the latest accident avoidance features are available, as is a rear-camera mirror, massaging front seats, and Caddy’s Super Cruise system. Pricing reportedly starts at just under $38,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d3703b3090f4300070d570d%2F2020-Cadillac-CT5%2F960x0.jpg%3FcropX1%3D288%26cropX2%3D5130%26cropY1%3D538%26cropY2%3D3261"
            });
            CarList.Add(new CarModel
            {
                CarName = "Chevrolet Corvette Stingray",
                CarColor = "Red",
                DrivenKM = "12359",
                Average = "19.5L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "A mid-engine Chevy Corvette has been rumored for decades and it’s a reality for 2020. Carrying the famed Stingray moniker, it’s the most aggressively styled ‘Vette yet, with a wild exotic-car appearance. It comes with removable roof panels that can be stored in the forward-situated trunk. A 6.2-liter V8 engine sits behind the driver and resides beneath a clear panel. It pumps 490 horsepower and 470 pound-feet of torque to the rear wheels via an eight-speed dual-clutch automatic transmission. The cockpit is driver-focused and features a pair of electronic displays and no fewer than a dozen selectable driving modes. A revised suspension promises added handling abilities, and it can be upgraded with an adjustable unit that lets the driver dial in stiffness and ride height, or General Motors’ Magnetic Ride Control auto-adjusting system. Amazingly, it starts at under $60,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d3703e2f1176b00089761a6%2F2020-Chevrolet-Corvette-Stingray%2F960x0.jpg%3FcropX1%3D836%26cropX2%3D5396%26cropY1%3D799%26cropY2%3D3364"
            });
            CarList.Add(new CarModel
            {
                CarName = "Electra Meccanica Solo",
                CarColor = "White",
                DrivenKM = "12351",
                Average = "24.9L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "A new name in the auto business, a Canadian company called Electra Meccanica says it will begin selling a new three-wheel single-passenger EV called Solo by year’s end. It looks a bit odd with its abbreviated styling, but will start at just $16,250. It boasts a 100-mile range, a top speed of 82 mph, and its 17.3 kWh battery pack can fully charge on a 220-volt circuit in three hours. Standard items include an LED instrument cluster, Bluetooth audio system, and a heated seat.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37041095e0230008f64ed8%2F2020-Electra-Meccanica-Solo%2F960x0.jpg%3FcropX1%3D24%26cropX2%3D2031%26cropY1%3D204%26cropY2%3D1333"
            });
            CarList.Add(new CarModel
            {
                CarName = "Ford Mustang Shelby GT500",
                CarColor = "Blue",
                DrivenKM = "41321",
                Average = "32.8L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "The 2020 Ford Mustang Shelby GT500 takes the original “pony car” to new levels of performance to keep up with the likes of the Chevrolet Camaro ZL1 and the Dodge Challenger SRT Hellcat. A hand-built supercharged 5.2-liter V8 engine channels a whopping 760 horsepower and 625 pound-feet of torque through the rear wheels via a seven-speed dual clutch automatic transmission. Ford says it can make the sprint to 60 mph in less than three seconds. There’s also suspension and steering upgrades, along with what Ford calls the largest front brake rotors ever available on an American sports coupe to help rein in all those raging horses. You’ll have to leave the kids at home, however, as the GT500 deletes the back seat to save weight.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37046395e0230008f64edf%2F2020-Ford-Mustang-Shelby-GT500%2F960x0.jpg%3FcropX1%3D299%26cropX2%3D2851%26cropY1%3D201%26cropY2%3D1638"
            });
            CarList.Add(new CarModel
            {
                CarName = "Kia Soul EV",
                CarColor = "Yellow",
                DrivenKM = "2412",
                Average = "30.9L",
                CarYear = "2020",
                FuelMode = "CNG",
                Details = "A redesigned version of Kia’s funky/boxy compact electric hatchback arrives later this year with styling differences that set it apart from the likewise recast gasoline versions. It will feature a 64 kWh lithium ion polymer battery pack that delivers an as-yet undisclosed range. Reports have it pegged around 225 miles, which is a considerable improvement over the current model’s 150-mile range. Its electric motor outputs 201 horsepower and a perky 291 pound-feet of torque. A new independent rear suspension helps enliven the car’s handling. The Soul EV comes with selectable driving modes, and the driver can choose from four levels of regenerative braking. A long list of amenities, including many of the latest accident-avoidance features, is included.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37049295e0230008f64eeb%2F2020-Kia-Soul-EV%2F960x0.jpg%3FcropX1%3D547%26cropX2%3D4924%26cropY1%3D592%26cropY2%3D3055"
            });
            CarList.Add(new CarModel
            {
                CarName = " McLaren GT",
                CarColor = "Golden",
                DrivenKM = "1231",
                Average = "22.4L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "Supercar maker McLaren debuts its first grand touring car for 2020, the appropriately named GT. A grand tourer is traditionally a more accommodating alternative to a flat out sports car that can be used as a daily driver or taken on extended road trips comfortably. The GT rides on a carbon fiber structure and its super sleek bodywork is comprised of aluminum panels, both for the sake of weight reduction. Its interior is both posh and driver focused, and a wealth of features includes a sophisticated infotainment system. A 4.0-liter V8 engine generates a lusty 612 horsepower with 465 pound-feet of launch happy torque. The automaker says it will reach 60 mph in a quick 3.1 seconds with a top speed of 203 mph. A new Proactive Damping Control suspension promises a smooth ride, while maintaining the appropriate McLaren levels of driving dynamics. Base price is a cool $210,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d35eb15f1176b0008974b5c%2F2020-McLaren-GT%2F960x0.jpg%3FcropX1%3D512%26cropX2%3D5312%26cropY1%3D602%26cropY2%3D3303"
            });
            CarList.Add(new CarModel
            {
                CarName = "Mini Cooper SE",
                CarColor = "Supper White",
                DrivenKM = "1234",
                Average = "34.5L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "Mini is launching a new full-electric Cooper SE coupe for 2020 that combines the brand’s famed go-kart-like handling with zero-emissions operation. It promises lively acceleration with its electric motor producing 181 horsepower with 199 pound-feet of torque. Expect a 0-60 mph time at 7.3 seconds. The Cooper SE features four driving modes and two regenerative braking selections, with the ability to engage one-pedal driving. Its official U.S.-spec operating range has not yet been established, but it’s rated to run for 146-167 miles on the European test cycle; its stated range will likely be less when the EPA evaluates it here.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d3704d0f1176b00089761ae%2F2020-Mini-Cooper-SE%2F960x0.jpg%3FcropX1%3D474%26cropX2%3D5315%26cropY1%3D297%26cropY2%3D3020"
            });
            CarList.Add(new CarModel
            {
                CarName = "Polestar 1",
                CarColor = "Gray",
                DrivenKM = "4211",
                Average = "23.1L",
                CarYear = "2020",
                FuelMode = "CNG",
                Details = "A new line of performance-minded electrified models from Volvo debuts for 2020 under the Polestar sub-brand that will offer its cars on a subscription basis online. To be built in China, the first model to hit the streets will be the Polestar 1. It’s a sleekly cast sporty plug-in hybrid coupe with two electric motors and a 2.0-liter turbo- and supercharged gasoline engine driving the front wheels. They generate a combined 591 horsepower and 738 pound-feet of torque, with an estimate electric-only range of around 93 miles. It will reportedly start at $155,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d3704fb090f4300070d573d%2F2020-Polestar-1%2F960x0.jpg%3FcropX1%3D48%26cropX2%3D2848%26cropY1%3D361%26cropY2%3D1937"
            });
            CarList.Add(new CarModel
            {
                CarName = "Polestar 2",
                CarColor = "Black",
                DrivenKM = "5124",
                Average = "22.00L",
                CarYear = "2020",
                FuelMode = "CNG",
                Details = "The new-for-2020 Polestar 2 is a full-electric four-door hatchback that rides on the same underpinnings as the Volvo XC40 crossover. Aimed squarely at the Tesla Model 3, it’s distinctively adorned with curves and creases and Volvo’s “Thor’s hammer” LED running lights. An all-wheel-drive electric powertrain is expected to put 408 horsepower and 487 pound-feet of torque to the pavement. Polestar is targeting an operating range of 330-miles on a charge. Its handling can be enhanced via a Performance Pack with suspension, brake, and wheel upgrades, and the vehicle includes phone-as-key technology. The Polestar 2 will be launched initially in California and Washington State and the company says it will carry a base price of $63,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37051e95e0230008f64f17%2F2020-Polestar-2%2F960x0.jpg%3FcropX1%3D678%26cropX2%3D3478%26cropY1%3D1045%26cropY2%3D2620"
            });
            CarList.Add(new CarModel
            {
                CarName = "Porsche Taycan",
                CarColor = "Black",
                DrivenKM = "8673",
                Average = "23.53L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "Porsche’s first-ever eclectic electric ride is an ultra-sleek battery-driven four-door sports car. It’s appropriately attractive with well-balanced proportions and Porsche styling cues. Porsche says the name Taycan is derived from two terms of Turkic origin, and can be roughly translated as “soul of a spirited young horse.” Two synchronous motors will generate in excess of 600 hp, and enable the Tacan to reach 60 mph in around 3.5 seconds. Porsche is targeting a range of over 300 miles with a full battery, and its 800-volt system will enable the car to recover 60 miles of range in four minutes via public fast-charging stations. What’s more, Taycan buyers will receive three years of unlimited 30-minute charging via the Electrify America network.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d370543f1176b00089761ce%2F2020-Porsche-Taycan%2F960x0.jpg%3FcropX1%3D329%26cropX2%3D2970%26cropY1%3D337%26cropY2%3D1822"
            });
            CarList.Add(new CarModel
            {
                CarName = "Tesla Roadster",
                CarColor = "Red",
                DrivenKM = "8932",
                Average = "30.00L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "Barring any production delays, the full-electric Tesla Roadster is expected to return for model year 2020 and hit the ground running. It features a decidedly modernistic curvy profile and promises rocket-like performance. A lightweight glass roof panel stores in the car’s trunk. Tesla claims it will be the fastest car on the planet, and one that can seat four at that. It’s said to make the leap to 60 mph in a sudden 1.9 seconds, with a highly illegal top speed of 250 mph. It’s operating range is claimed to be as much as 620 miles on a charge. The Roadster starts at $200,000, with prospective owners asked to put up a $50,000 reservation to be among the first to own one.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d35eb4795e0230008f63724%2F2020-Tesla-Roadster%2F960x0.jpg%3FcropX1%3D282%26cropX2%3D3354%26cropY1%3D157%26cropY2%3D1885"
            });
            CarList.Add(new CarModel
            {
                CarName = "Toyota GR Supra",
                CarColor = "Black",
                DrivenKM = "42521",
                Average = "29.87L",
                CarYear = "2020",
                FuelMode = "Diseal",
                Details = "Toyota brings back the Supra for 2020 after being absent from its U.S. lineup for 21 years, and it remains an eminently stylish and capable sports car. Sharing components with the BMW Z4 roadster, the two-seater’s bodywork is radically curvy, with a “double bubble” roof and long and pronounced scoops along the sides. It packs a turbocharged 3.0-liter inline six-cylinder engine that channels 335 horsepower and 365 pound-feet of torque to the rear wheels. Coming with an eight-speed automatic transmission, the GR Supra is good for a 4.1-second 0-60 mph run. A sophisticated suspension, active rear differential and a perfect 50:50 front-to-rear weight ratio combine for crisp cornering abilities. It starts at just shy of $51,000.",
                Image = "https://thumbor.forbes.com/thumbor/960x0/https%3A%2F%2Fspecials-images.forbesimg.com%2Fimageserve%2F5d37057895e0230008f64f45%2F2020-Toyota-GR-Supra%2F960x0.jpg%3FcropX1%3D242%26cropX2%3D3122%26cropY1%3D229%26cropY2%3D1849"
            });
        }
    }
}
